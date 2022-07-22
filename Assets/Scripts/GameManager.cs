using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    private PlayerInteractions playerInteractions;
    private Character currentCharacter;

    //public bool reported = false;
    public bool won;

    [SerializeField] private GameObject player;
    [SerializeField] private Character character1,character2,character3,character4,character5;

    // Start is called before the first frame update
    void Start()
    {
        playerInteractions = FindObjectOfType<PlayerInteractions>();
        currentCharacter = character1;
       
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
