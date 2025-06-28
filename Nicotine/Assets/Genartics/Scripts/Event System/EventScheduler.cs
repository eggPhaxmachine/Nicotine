using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class EventScheduler : MonoBehaviour
{
    public int Index; 

    protected Path curPath;

    
    public void schedule(Path path)
    {
        curPath = path;
    }

    public void begin()
    {
        Index = 1;
        curPath.runIndex(Index);
    }

    public void ping()
    {

        while (curPath.isIndexFinished(Index))
        {
            if (Index < curPath.startSchedual.Count)
            {
                Index++;
            }
            else if (curPath.next() != null)
            {

                curPath = curPath.next();
                Index = 1;
            }
            else
            {
                break;
            }

            curPath.runIndex(Index);
        }
    }

}