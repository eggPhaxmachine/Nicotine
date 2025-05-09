using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Path
{
    public List<List<Event>> events = new List<List<Event>>();

    private List<BackgroundEvent> backgroundEvents = new List<BackgroundEvent>();

    public void add(Event evt)
    {
        List<Event> path = new List<Event> { evt };

        events.Add(path);
    }

    public void add(Event evt, int location)
    {
        events[location - 1].Add(evt);
    }

    public abstract Path next();


}
