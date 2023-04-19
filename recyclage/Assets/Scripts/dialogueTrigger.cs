using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public Rigidbody2D player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        player.bodyType = RigidbodyType2D.Static;
        FindObjectOfType<dialogeManager>().StartDialogue(dialogue);
    }

}
