using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EventScedualer : MonoBehaviour
{

    public TextMeshProUGUI mainTextBox;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(dialogeTools.dialogeCoroutine(textAssets.test.test1, 40, mainTextBox));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
