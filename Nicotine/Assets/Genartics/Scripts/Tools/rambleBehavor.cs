using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class rambleBehavor : MonoBehaviour
{

    public TextMeshProUGUI textBox;

    public bool active = false;

    int speed;
    string[] text;

    int dialogeIndex = 0;
    int charIndex = 0;
    float time = 0;

    public async void activate(string[] text, int speed)
    {

        this.text = text;
        this.speed = speed;

        active = true;

        while (active)
        {
            execute();

            await Task.Yield();
        }
    }

    public void deactivate()
    {
        active = false;
    }

    public void execute()
    {

        time += Time.deltaTime * speed;

        if (dialogeIndex < text.Length)
        {

            if (charIndex < text[dialogeIndex].Length)
            {

                charIndex = Mathf.FloorToInt(time);

                textBox.text = text[dialogeIndex].Substring(0, charIndex);

            }
            else
            {
                dialogeIndex++;
                charIndex = 0;
            }

        }
        else
        {

            dialogeIndex = 0;
            charIndex = 0;
            time = 0;

        }
    }
}
