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
    public Animator animator;
    public Rigidbody2D player;


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
        animator.SetBool("IsOpen", true);
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
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    private IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        dialogueBox.gameObject.SetActive(false);
        dialogueText.gameObject.SetActive(false);
        dialogueImage.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        player.bodyType = RigidbodyType2D.Dynamic;

    }
}
