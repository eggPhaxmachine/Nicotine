using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choicePath : Path
{

    Path[] choices;
    simplePivoteEvent pivot;

    public choicePath(simplePivoteEvent pivot, params Path[] choices)
    {
        this.pivot = pivot;
        this.choices = choices;
    }

    public choicePath(params Path[] choices)
    {
        this.choices = choices;
    }

    public void setPivot(simplePivoteEvent newPivot)
    {
        pivot = newPivot;
    }

    public override Path next()
    {
        return choices[pivot.pivot()];
    }
}
