using System.Collections;
using TMPro;
using UnityEngine;

public class dialogeEvent   : Event {

    string[] text;
    float speed;
    TextMeshProUGUI textBox;

    public dialogeEvent(string[] text, float speed, TextMeshProUGUI textBox)
    {
        this.text = text;
        this.speed = speed;
        this.textBox = textBox;
    }

    protected override void onStart()
    {
    
    }

    public override IEnumerator execute()
    {
        return dialogeCoroutine(text, speed, textBox);
    }

    public override bool isFinished()
    {
        return finished;
    }

    public override void end()
    {
        
    }

    public IEnumerator dialogeCoroutine(string[] text, float speed, TextMeshProUGUI textBox)
    {
        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }

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

            while (!Input.GetMouseButtonDown(0))
            {
                yield return null;
            }

            dialogeIndex++;

        }

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }

        textBox.text = "";

        finished = true;

    }
}

public class ramble : BackgroundEvent
{

    string[] text;
    float speed;
    TextMeshProUGUI textBox;


    public ramble(string[] text, float speed, TextMeshProUGUI textBox)
    {
        this.text = text;
        this.speed = speed;
        this.textBox = textBox;
    }

    int dialogeIndex = 0;
    int charIndex = 0;
    float time = 0;

    public override void execute()
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

    protected override void end()
    {
        textBox.text = "";
    }
}