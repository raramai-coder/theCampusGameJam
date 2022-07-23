using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using TMPro;


public class GameManager : MonoBehaviour
{
    private PlayerInteractions playerInteractions;
    

    //public bool reported = false;
    public bool won;
    public Character currentCharacter;

    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI characterNameLabel;
    [SerializeField] private GameObject Paper, NoteBook;

    // Start is called before the first frame update
    void Start()
    {
        playerInteractions = FindObjectOfType<PlayerInteractions>();
    }

    public void DisplayCharacterNotes()
    {
        Paper.SetActive(true);
        NoteBook.SetActive(false);
        characterNameLabel.text = currentCharacter.name + "'s Notes";
    }

    public void Report()
    {
        if (currentCharacter.decoy)
        {
            won = true;
        }
        else
        {
            won = false;
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
}
