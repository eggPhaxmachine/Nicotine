using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScheduler : MonoBehaviour
{ 

    private List<Event> events = new List<Event>();

    public void schedule(Event evt)
    {
        events.Add(evt);
    }

    public void run()
    {
        StartCoroutine(createCorotine());
    }

    public IEnumerator createCorotine()
    {
        foreach (Event evt in events)
        {
            evt.initialize();

            evt.execute();

            while (!evt.isFinished())
            {
                yield return null;
            }

            evt.end();
        }
    }
}