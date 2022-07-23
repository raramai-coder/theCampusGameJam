using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTaking : MonoBehaviour
{
    public Character characterToNoteFrom;
    public int key;
    public int dictionary;

    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/


    public void TakeNoteDialogue()
    {
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
    /*// Update is called once per frame
    void Update()
    {
        
    }*/


}
