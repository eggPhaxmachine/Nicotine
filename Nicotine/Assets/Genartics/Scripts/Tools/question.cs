using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : simplePivoteEvent
{

    GameObject[] objects;
    Button[] buttons;
    bool[] wasPressed;
    int choice;

    public question(params GameObject[] objects)
    {
        this.objects = objects;
        buttons = new Button[objects.Length];
        wasPressed = new bool[objects.Length];
    }

    protected override void onStart()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].GetComponent<Button>() == null)
            {
                objects[i].AddComponent<Button>();
            }

            buttons[i] = objects[i].GetComponent<Button>();

            int index = i;

            buttons[i].onClick.AddListener(() =>
            {
                wasPressed[index] = true;
            });
        }
    }

    public override IEnumerator execute()
    {
        while (!finished)
        {
            for (int i = 0; i < wasPressed.Length; i++)
            {
                if (wasPressed[i])
                {
                    choice = i;
                    finished = true;
                    break;
                }
            }

            yield return null;
        }
    }

    public override int pivot()
    {
        return choice;
    }
}
