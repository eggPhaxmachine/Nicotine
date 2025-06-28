using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Event
{

    EventScheduler scheduler;

    public Action run;

    public int startIndex;
    public int endIndex;

    public eventStatus curStatus;

    public enum eventStatus
    {
        WAITING,
        RUNNING,
        FINISHED
    }

    public Event(Action action, int startIndex, int endIndex)
    {
        this.startIndex = startIndex;
        this.endIndex = endIndex;

        curStatus = eventStatus.WAITING;

        scheduler = GameObject.FindObjectOfType<Canvas>().GetComponent<EventScheduler>();

        run = () =>
        {
            
            setStatus(eventStatus.RUNNING);
            action();
            markFinished();
        };

    }

    public Event(IEnumerator coroutine, int startIndex, int endIndex)
    {
        this.startIndex = startIndex;
        this.endIndex = endIndex;

        curStatus = eventStatus.WAITING;

        scheduler = GameObject.FindObjectOfType<Canvas>().GetComponent<EventScheduler>();

        run = () => scheduler.StartCoroutine(coroutineNest(coroutine));

    }

    public IEnumerator coroutineNest(IEnumerator coroutine)
    {
        setStatus(eventStatus.RUNNING);
        yield return coroutine;
        markFinished();
    }

    public void setStatus(eventStatus status)
    {
        curStatus = status;
    }

    public void markFinished()
    {
        curStatus = eventStatus.FINISHED; 
        if (scheduler.Index == endIndex)
        {
            scheduler.ping();
        }
    }

}
