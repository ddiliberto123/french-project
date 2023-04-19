using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dialogeManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public Image dialogueBox;
    public Image dialogueImage;
    public Button continueButton;
    private Queue<string> sentences;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        sentences.Clear();
        dialogueBox.gameObject.SetActive(true);
        dialogueText.gameObject.SetActive(true);
        dialogueImage.gameObject.SetActive(true);
        continueButton.gameObject.SetActive(true);
        foreach (string sentence in dialogue.sentences)
        {
            Debug.Log(sentence);
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }

    void EndDialogue()
    {
        Debug.Log("Done");
        dialogueBox.gameObject.SetActive(false);
        dialogueText.gameObject.SetActive(false);
        dialogueImage.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        Time.timeScale = 1.0f;

    }
}
