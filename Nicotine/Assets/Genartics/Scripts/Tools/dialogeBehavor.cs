using System.Collections;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class dialogeBehavor : MonoBehaviour
{

    public TextMeshProUGUI textBox;

    public IEnumerator execute(string[] text, float speed)
    {
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        int dialogeIndex = 0;

        while (dialogeIndex < text.Length)
        {
            int charIndex = 0;
            float t = 0;

            while (charIndex < text[dialogeIndex].Length)
            {

                t += Time.deltaTime * speed;
                charIndex = Mathf.FloorToInt(t);

                textBox.text = text[dialogeIndex].Substring(0, charIndex);

                yield return null;

            }


            textBox.text = text[dialogeIndex];

            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

            dialogeIndex++;

        }

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        textBox.text = "";

    }
}

