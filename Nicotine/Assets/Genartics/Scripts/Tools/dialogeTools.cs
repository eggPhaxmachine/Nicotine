using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;

public class dialogeEvent : Event {

    string[] text;
    float speed;
    TextMeshProUGUI textBox;

    public dialogeEvent(string[] text, float speed, TextMeshProUGUI textBox)
    {
        this.text = text;
        this.speed = speed;
        this.textBox = textBox;
    }

    public override void execute()
    {
        StartCoroutine(dialogeCoroutine(text, speed, textBox));
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

        finished = true;

    }
}
