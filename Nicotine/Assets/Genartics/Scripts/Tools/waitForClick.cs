using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waitForClick : MonoBehaviour
{

    public Button button;
    bool wasPressed = false;

<<<<<<< Updated upstream
<<<<<<< Updated upstream
    protected void onStart()
=======
<<<<<<< Updated upstream
=======
>>>>>>> Stashed changes
    public waitForClick(GameObject Object)
=======
    private void Start()
>>>>>>> Stashed changes
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    {
        button.onClick.AddListener(() =>
        {
            wasPressed = true;
        });

    }

    public IEnumerator execute()
    {
<<<<<<< Updated upstream
        while (!wasPressed)
        {
            yield return new WaitUntil(() => wasPressed);
        }
<<<<<<< Updated upstream
=======

        finished = true;
=======
        yield return new WaitUntil(() => wasPressed);
>>>>>>> Stashed changes
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
