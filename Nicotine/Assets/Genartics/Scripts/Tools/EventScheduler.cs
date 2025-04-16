using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScheduler : MonoBehaviour
{ 

    private List<List<Event>> events = new List<List<Event>>();

    public void schedule(Event evt)
    {
        List<Event> path = new List<Event>{evt};

        events.Add(path);
    }

    public void schedule(Event evt, int location)
    {
        events[location - 1].Add(evt);
    }

    public void run()
    {
        StartCoroutine(createCorotine());
    }

    public IEnumerator createCorotine()
    {

        List<Event> runningEvents = new List<Event>();

        foreach (List<Event> path in events)
        {
            foreach (Event evt in path)
            {

                evt.initialize();

                StartCoroutine(evt.execute());

                runningEvents.Add(evt);

            }

            while (runningEvents.Count != 0)
            {
                for (int i = 0; i < events.Count; i++)
                {
                    if (path[i].isFinished())
                    {
                        runningEvents.RemoveAt(i);
                    }
                }

                yield return null;

            }

            foreach(Event evt in path)
            {
                evt.end();
            }
        }
    }
}