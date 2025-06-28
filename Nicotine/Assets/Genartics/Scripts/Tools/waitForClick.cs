using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waitForClick : Event
{

    GameObject Object;
    Button button;
    bool wasPressed = false;

    public waitForClick(GameObject Object)
    {
        this.Object = Object;
    }

    protected override void onStart()
    {
        if (Object.GetComponent<Button>() == null)
        {
              Object.AddComponent<Button>();
        }

        button = Object.GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            wasPressed = true;
        });
    }

    public override IEnumerator execute()
    {
        while (!wasPressed)
        {
            yield return null;
        }

        finished = true;
    }
}
