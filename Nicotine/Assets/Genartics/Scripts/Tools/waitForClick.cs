using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waitForClick : MonoBehaviour
{

    public Button button;
    bool wasPressed = false;

    protected void onStart()
    {
        button.onClick.AddListener(() =>
        {
            wasPressed = true;
        });
    }

    public IEnumerator execute()
    {
        while (!wasPressed)
        {
            yield return new WaitUntil(() => wasPressed);
        }
    }
}
