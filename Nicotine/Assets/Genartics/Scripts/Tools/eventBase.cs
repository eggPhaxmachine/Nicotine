using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventBase : Event
{
    protected override void onStart()
    {
        
    }

    public override IEnumerator execute()
    {
        finished = true;
        return null;
    }

    public override void end()
    {
        
    }
}
