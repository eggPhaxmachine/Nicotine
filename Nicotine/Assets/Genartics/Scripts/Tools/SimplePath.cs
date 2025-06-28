using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePath : Path
{

    Path nextPath;

    public SimplePath(Path nextPath) 
    {
        this.nextPath = nextPath;
    }

    public override Path next()
    {
        return nextPath;
    }
}
