using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private PlayerInteractions playerInteractions;
    private List<GameObject> notesPresented = new List<GameObject>();
    

    //public bool reported = false;
    public bool won,notebookOpen;
    public Character currentCharacter;

    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI characterNameLabel;
    [SerializeField] private GameObject Paper, NoteBook, noteTextPrefab, notesContainer;

    GameObject[] characters;

    // Start is called before the first frame update
    void Start()
    {
        playerInteractions = FindObjectOfType<PlayerInteractions>();
        notebookOpen = false;
        characters = GameObject.FindGameObjectsWithTag("character");
    }

    public void ToggleNotebook()
    {
        if (notebookOpen)
        {
            notebookOpen = false;
            NoteBook.SetActive(false);
        }
        else
        {
            notebookOpen = true;
            NoteBook.SetActive(true);
        }
    }

    public void DisplayCharacterNotes()
    {
        Paper.SetActive(true);
        NoteBook.SetActive(false);
        characterNameLabel.text = currentCharacter.name + "'s Notes";

        if (notesPresented.Count > 0)
        {
            foreach(GameObject noteObkect in notesPresented)
            {
                Destroy(noteObkect);
            }
        }

        foreach(string note in currentCharacter.notesTaken)
        {
            GameObject obj = Instantiate(noteTextPrefab);
            obj.transform.SetParent(notesContainer.transform);
            TextMeshProUGUI noteText = obj.GetComponent<TextMeshProUGUI>();
            noteText.text = "~ " + note;
            notesPresented.Add(obj);
        }
    }

    public void Report()
    {
        if (currentCharacter.decoy)
        {
           SceneManager.LoadScene("YouWon");
        }
        else
        {
            SceneManager.LoadScene("YouLost");
        }

        Debug.Log(won);
    }

    public void ExitCharacterNoteBook()
    {
        Paper.SetActive(false);
        NoteBook.SetActive(true);
    }
    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    /// <summary>
    /// A function that stops the camera from moving when the player is interacting with the objects.
    /// </summary>
    public void ControlMovement()
    {
        if (playerInteractions.canMove)    //if the player can move, eneable the firstperson controller script to allow them to make movements
        {
            player.GetComponent<FirstPersonController>().enabled = true;
        }
        else                              //otherwise if the player isnt supposed to moe, disable the firstperson controller so that the player can't move
        {
            player.GetComponent<FirstPersonController>().enabled = false;
        }
    }

    public void DisableInteractableIndicators()
    {
        Objects[] allObjects = FindObjectsOfType<Objects>();

        foreach(Objects currentObject in allObjects)
        {
            if (currentObject.indicatorActive)
            {
                currentObject.interactionIndicator.SetActive(false);
                currentObject.indicatorActive = false;
            }
            
        }
    }

    public void Update()
    {
        // foreach(GameObject character in characters)
        // {
        //     IndividualCharacter script = character.GetComponent<IndividualCharacter>();
        //     if(script.currentSource.loop == false)
        //     {
        //         script.currentSource.Stop();
        //     }
        // }
    }
}
