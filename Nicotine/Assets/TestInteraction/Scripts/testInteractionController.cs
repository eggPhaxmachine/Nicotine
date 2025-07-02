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
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
=======
        SimplePath choicePath1 = new SimplePath(null);
        SimplePath choicePath2 = new SimplePath(null);
        SimplePath choicePath3 = new SimplePath(null);
=======
<<<<<<< Updated upstream
=======

    GameObject kirckle;

    // Start is called before the first frame update
    void Start()
    { 
>>>>>>> Stashed changes
>>>>>>> Stashed changes

    GameObject kirckle;

<<<<<<< Updated upstream
    // Start is called before the first frame update
    void Start()
    { 
>>>>>>> Stashed changes
>>>>>>> Stashed changes

        SimplePath testPath2 = new SimplePath(null);
        SimplePath testPath = new SimplePath(testPath2);

<<<<<<< Updated upstream
        testPath.schedule(mainTextBox.GetComponent<dialogeBehavor>().execute(textAssets.test.test1, 40), 1);
        testPath.schedule(playerTextBox.GetComponent<dialogeBehavor>().execute(textAssets.test.test3, 40), 1);
        testPath.schedule(simpleButton.GetComponent<waitForClick>().execute(), 1);
=======
=======
>>>>>>> Stashed changes
<<<<<<< Updated upstream
        //question question1 = new question(square, triamgle, kerklay);
        //questionPath1.setPivot(question1);
=======
        testPath.schedule(mainTextBox.GetComponent<dialogeBehavor>().execute(textAssets.test.test1, 40), 1);
        testPath.schedule(playerTextBox.GetComponent<dialogeBehavor>().execute(textAssets.test.test3, 40), 1);
        testPath.schedule(() => { kirckle = Object.Instantiate(simpleButton, new Vector3(400, 0, 0), new Quaternion(), canvas.GetComponent<RectTransform>()); }, 2);
        testPath.schedule(kirckle.GetComponent<waitForClick>().execute(), 3);
        //testPath.schedule(simpleButton.GetComponent<waitForClick>().execute(), 1);
>>>>>>> Stashed changes
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

        testPath2.schedule(playerTextBox.GetComponent<dialogeBehavor>().execute(textAssets.test.test2, 40), 1);

        schedule(testPath);
        begin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
