using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScheduler : MonoBehaviour
{
    private Path curPath;

    private List<BackgroundEvent> backgroundEvents = new List<BackgroundEvent>();

    public void addBackground(BackgroundEvent evt)
    {
        backgroundEvents.Add(evt);
    }

    public void schedule(Path path)
    {
        curPath = path;
    }

    public void run()
    {
        StartCoroutine(createCorotine());
        startBackground();
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

    public void startBackground()
    {
        foreach(BackgroundEvent evt in backgroundEvents)
        {
            StartCoroutine(evt.loop());
        }
    }

    public void startBackground(int id)
    {
        StartCoroutine(backgroundEvents[id - 1].loop());
    }
}