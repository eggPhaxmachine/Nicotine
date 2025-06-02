using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class testInteractionController : EventScheduler
{

    public float speed;

    public TextMeshProUGUI mainTextBox;
    public TextMeshProUGUI playerTextBox;

    public Canvas Canvas;

    public GameObject simpleButton;
    

    // Start is called before the first frame update
    void Start()
    {
        SimplePath choicePath1 = new SimplePath(null);
        SimplePath choicePath2 = new SimplePath(null);
        SimplePath choicePath3 = new SimplePath(null);

        choicePath questionPath1 = new choicePath(choicePath1, choicePath2, choicePath3);

        //question question1 = new question(square, triamgle, kerklay);
        //questionPath1.setPivot(question1);

        //questionPath1.addBackground(new ramble(textAssets.test.ramble1, speed, playerTextBox));
        //questionPath1.schedule(new dialogeEvent(textAssets.test.question1, speed, mainTextBox));
        //questionPath1.schedule(question1);

        //choicePath1.schedule(new dialogeEvent(textAssets.test.choice1, speed, mainTextBox));
        //choicePath2.schedule(new dialogeEvent(textAssets.test.choice2, speed, mainTextBox));
        //choicePath3.schedule(new dialogeEvent(textAssets.test.choice3, speed, mainTextBox));

        //schedule(questionPath1);

        //run();

        Instantiate(simpleButton, new Vector3(1000, 600, 0), new Quaternion(), Canvas.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
