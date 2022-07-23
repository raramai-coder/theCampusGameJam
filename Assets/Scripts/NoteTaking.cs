using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTaking : MonoBehaviour
{
    public Character characterToNoteFrom;
    public int key;
    public int dictionary;

    GameObject NotificationPanel;
    [SerializeField]
    private AudioSource source;

    void Start()
    {
        NotificationPanel = GameObject.FindGameObjectWithTag("NotificationPanel");
        NotificationPanel.SetActive(false);
        source = gameObject.GetComponent<AudioSource>();
        source.Stop();
    }


    public void TakeNoteDialogue()
    {

         StartCoroutine("NotificationTime");
        
        if (dictionary == 0)
        {
            characterToNoteFrom.notesTaken.Add(characterToNoteFrom.answersNotes[key]);
            Debug.Log(characterToNoteFrom.answersNotes[key]);
        }
        else
        {
            characterToNoteFrom.notesTaken.Add(characterToNoteFrom.thoughtsNotes[key]);
            Debug.Log(characterToNoteFrom.thoughtsNotes[key]);
        }    
    }

    private void TakeNoteObject()
    {
    }

    IEnumerator NotificationTime()
    {
        source.Play();
        NotificationPanel.SetActive(true);
        yield return new WaitForSeconds(3);
        NotificationPanel.SetActive(false);
        source.Stop();
    }
}
    
