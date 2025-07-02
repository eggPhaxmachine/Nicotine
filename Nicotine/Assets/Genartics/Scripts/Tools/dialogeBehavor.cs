using System.Collections;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
using System.Threading.Tasks;
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
using TMPro;
using UnityEngine;

public class dialogeBehavor : MonoBehaviour
{
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
=======
>>>>>>> Stashed changes
/*
    public bool skip = false;

    private void Start()
    {
        InputListener.onLeftClick += () =>
        {
            skip = true;
        };
    }
 */  
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    public TextMeshProUGUI textBox;

    public IEnumerator execute(string[] text, float speed)
    {
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
        yield return new WaitUntil(() => Input.GetMouseButtonUp(0));
>>>>>>> Stashed changes
=======
        yield return new WaitUntil(() => Input.GetMouseButtonUp(0));
>>>>>>> Stashed changes

        int dialogeIndex = 0;

        while (dialogeIndex < text.Length)
        {
            int charIndex = 0;
            float t = 0;

<<<<<<< Updated upstream
<<<<<<< Updated upstream
            while (charIndex < text[dialogeIndex].Length)
=======
            while (charIndex != text[dialogeIndex].Length)
>>>>>>> Stashed changes
=======
            while (charIndex != text[dialogeIndex].Length)
>>>>>>> Stashed changes
            {

                t += Time.deltaTime * speed;
                charIndex = Mathf.FloorToInt(t);

                textBox.text = text[dialogeIndex].Substring(0, charIndex);

<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes
                if (Input.GetMouseButtonDown(0))
                {
                    charIndex = text[dialogeIndex].Length;
                    yield return new WaitUntil(() => Input.GetMouseButtonUp(0));
                }

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                yield return null;

            }

<<<<<<< Updated upstream
<<<<<<< Updated upstream

            textBox.text = text[dialogeIndex];

            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
=======
=======
>>>>>>> Stashed changes
            textBox.text = text[dialogeIndex];

            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            yield return new WaitUntil(() => Input.GetMouseButtonUp(0));
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

            dialogeIndex++;

        }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        textBox.text = "";

    }
}

