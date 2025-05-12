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
        SimplePath path2 = new SimplePath(null);
        SimplePath path1 = new SimplePath(path2);

        path1.schedule(new dialogeEvent(textAssets.test.test1, speed, mainTextBox));
        path1.addBackground(new ramble(textAssets.test.test2, speed, playerTextBox));

        path2.schedule(new dialogeEvent(textAssets.test.test2, speed, playerTextBox));

        schedule(path1);

        run();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
