using System;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    
    public static event Action onLeftClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) onLeftClick?.Invoke();
    }

}
