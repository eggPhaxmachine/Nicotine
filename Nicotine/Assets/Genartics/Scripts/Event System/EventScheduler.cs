using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class EventScheduler : MonoBehaviour
{
    protected Path curPath;

    protected List<BackgroundEvent> backgroundEvents = new List<BackgroundEvent>();

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
    
    protected IEnumerator createCorotine()
    {
        while (curPath != null)
        {
            bool[] runningEvents;

            foreach (List<Event> parrelleEvent in curPath.events)
            {
                runningEvents = new bool[parrelleEvent.Count];

                for (int i = 0; i < parrelleEvent.Count; i++)
                {

                    parrelleEvent[i].initialize();

                    StartCoroutine(parrelleEvent[i].execute());

                    runningEvents[i] = true;

                }

                while (!runningEvents.All(evt => evt == false))
                {
                    for (int i = 0; i < parrelleEvent.Count; i++)
                    {
                        if (parrelleEvent[i].isFinished() && runningEvents[i])
                        {
                            runningEvents[i] = false;
                            parrelleEvent[i].end();
                        }
                    }

                    yield return null;

                }
            }

            curPath = curPath.next();

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