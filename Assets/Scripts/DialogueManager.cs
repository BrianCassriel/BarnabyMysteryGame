using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text clueText;
    public Text dialougeText;
    public Animator animator;
    
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialouge(Dialouge dialouge)
    {
        animator.SetBool("IsOpen", true);
        Debug.Log("Starting conversaton with" + dialouge.clue);

        clueText.text = dialouge.clue;
        
        sentences.Clear();
        foreach (string sentence in dialouge.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialouge();
            return;
        }

        string sentence = sentences.Dequeue();
        dialougeText.text = sentence;
    }

    public void EndDialouge()
    {
        Debug.Log("End of cnversation");
        animator.SetBool("IsOpen", false);
    }
}
