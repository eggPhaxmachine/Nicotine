using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class testInteractionController : MonoBehaviour
{
    EventScheduler testInteraction = new EventScheduler();

    public float speed;

    public TextMeshProUGUI mainTextBox;
    public TextMeshProUGUI playerTextBox;

    // Start is called before the first frame update
    void Start()
    {
        testInteraction.schedule(new dialogeEvent(textAssets.test.test1, speed, mainTextBox));
        testInteraction.schedule(new dialogeEvent(textAssets.test.test2, speed, playerTextBox));

        testInteraction.run();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
