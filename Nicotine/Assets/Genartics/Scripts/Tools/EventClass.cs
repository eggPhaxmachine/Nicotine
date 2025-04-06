using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering.VirtualTexturing;

public abstract class Event : MonoBehaviour
{
    protected bool finished;

    public void initialize()
    {
        finished = false;
    }

    public abstract void execute();

    public abstract bool isFinished();
    
    public abstract void end();

}
