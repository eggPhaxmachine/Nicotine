using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class testInteractionController : EventScheduler
{

    public float speed;

    public GameObject mainTextBox;
    public GameObject playerTextBox;

    public Canvas canvas;

    public GameObject simpleButton;

    

    // Start is called before the first frame update
    void Start()
    {

        SimplePath testPath2 = new SimplePath(null);
        SimplePath testPath = new SimplePath(testPath2);

        testPath.schedule(mainTextBox.GetComponent<dialogeBehavor>().execute(textAssets.test.test1, 40), 1);
        testPath.schedule(playerTextBox.GetComponent<dialogeBehavor>().execute(textAssets.test.test3, 40), 1);
        testPath.schedule(simpleButton.GetComponent<waitForClick>().execute(), 1);

        testPath2.schedule(playerTextBox.GetComponent<dialogeBehavor>().execute(textAssets.test.test2, 40), 1);

        schedule(testPath);
        begin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
