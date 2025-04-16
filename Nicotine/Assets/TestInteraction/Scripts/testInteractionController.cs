using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class testInteractionController : EventScheduler
{

    public float speed;

    public TextMeshProUGUI mainTextBox;
    public TextMeshProUGUI playerTextBox;

    // Start is called before the first frame update
    void Start()
    {
        schedule(new dialogeEvent(textAssets.test.test1, speed, mainTextBox));
        addBackground(new ramble(textAssets.test.test2, speed, playerTextBox));

        run();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
