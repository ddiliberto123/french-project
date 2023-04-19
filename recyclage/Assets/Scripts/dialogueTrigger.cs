using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Time.timeScale = 0f;
        FindObjectOfType<dialogeManager>().StartDialogue(dialogue);
    }

}
