using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Path
{
    
    public SortedDictionary<int, List<Event>> startSchedual = new SortedDictionary<int, List<Event>>();
    public SortedDictionary<int, List<Event>> endSchedual = new SortedDictionary<int, List<Event>>();

    public void addEvent(Event evt, int startIndex, int endIndex)
    {
        if (startSchedual.TryGetValue(startIndex, out List<Event> startLocation))
        {
            startLocation.Add(evt);
        }
        else
        {
            startSchedual.Add(startIndex, new List<Event> { evt });
        }

        if (endSchedual.TryGetValue(endIndex, out List<Event> endLocation))
        {
            endLocation.Add(evt);
        }
        else
        {
            endSchedual.Add(endIndex, new List<Event> { evt });
        }
    }

    public void schedule(Action action, int startIndex, int endIndex)
    {

        if(startIndex < 1 || endIndex < 1)
        {
            throw new ArgumentOutOfRangeException("cannot schedual event with an index less than 1");
        }

        Event evt = new Event(action, startIndex, endIndex);

        addEvent(evt, startIndex, endIndex);
    }

    public void schedule(Action action, int index)
    {
        schedule(action, index, index);
    }

    public void schedule(IEnumerator coroutine, int startIndex, int endIndex)
    {

        if (startIndex < 1 || endIndex < 1)
        {
            throw new ArgumentOutOfRangeException("cannot schedual event with an index less than 1");
        }

        Event evt = new Event(coroutine, startIndex, endIndex);

        addEvent(evt, startIndex, endIndex);
    }
    public void schedule(IEnumerator coroutine, int index)
    {
        schedule(coroutine, index, index);
    }

    public void runIndex(int index)
    {
        if (startSchedual.TryGetValue(index, out List<Event> Index))
        {
            foreach (Event evt in Index)
            {
                evt.run();
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException("cannot run index " + index + ", it does not exist");
        }
    }

    public bool isIndexFinished(int index)
    {
        bool isFinished = true;

        if (startSchedual.TryGetValue(index, out List<Event> Index))
        {
            int i = 0;

            while (isFinished && i < Index.Count)
            {
                isFinished = Index[i].curStatus == Event.eventStatus.FINISHED;
                i++;
            }
        }

        return isFinished;

    }

    public virtual Path next()
    {
        return null;
    }

}