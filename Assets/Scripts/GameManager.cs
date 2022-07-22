using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    private PlayerInteractions playerInteractions;
    private Character Roli, Kalushi, Bandile, James, Thandi;

    public bool reported = false;
    public bool won;

    [SerializeField] private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        playerInteractions = FindObjectOfType<PlayerInteractions>();
        /*Roli = new Character("Roli", false, "What happened to the other boxing glove?", "How do you not see black officers as traitors?", "I was held captive by a police officer whilst walking home day, he took his pants off and pissed on me. No one should be treated like this.", "Fight violence with violence.", "I lost one, whilst crossing over the Limpopo River from South Africa into Mozambique", "My brother is a prison warden, they are just doing their jobs.", "He's a skilled boxer, and I heard that he met with Robert Subukwe in person for legal advice.", "He's too sympathetic towards black traitors who guard the prisons.");
        Kalushi = new Character("Kalushi", false, "Why was your jail sentence shortened?", "What's so great about Jazz?", "When my brother was sent to prison, the police officers beat my brother to the ground. When the same thing happened to me a few years later, I knew I was going to fight to ensure that never would another innocent black be treated like that again." , "Fight violence with violence.", "How does that concern you? Mind your own business.", "He went to prison for stabbing a police officer.", "He received 10 years in prison, but got out 5 years early, no one knows how.", "He's an amazing jazz player, I really enjoy having him around.");
        Bandile = new Character("Bandile", false, "Why don't you like music?", "Why did you join the ANC and not the PAC?", "After witnessing the June 16th Soweto Youth uprising and seeing how over 1000 teenagers/young adults were injured by the police force. I vowed to do everything I could to stop those who have colonised us.", "Fight violence with violence.", "Stop messing around and focus on your training.",  "Jazz is revolutionary", "I love his photos, you should ask him to take one of you.", "He doesn't like music. How can you trust an Africanwho doesn't like to boogie?");
        James = new Character("James", true, "If you're a pacifisit, why did you join the militiary wing, Umkhonte we Sizwe?", "What was it like growing up in a small rural town?", "I heard about what happened at the Soweto Uprsing, and knew that I had to fight for my people.", "Pacifism is the better route.", "I joined because I wanted to be helpful to the struggle.", "It was very religous, and made me the man I am today.", "He has strong christian values and sings struggle songs with great fervour!", "It's a bit suspicious, how he only just recently joined the ANC and seems to have reserved political views.");
        Thandi = new Character("Thandi", false, "If you're not South African, why have you joined the ANC?", "What happened to your parents?", "I see how harshly the police treat those of us with black skin and I can't stand back and watch it happen anymore.", "Fight violence with violence.", "I like that they're not afraid to fight fire with fire.", "My father was South African, he died fighting for the ANC leaving me in an orphanage.", "She's a strong yet ruthless fighter, a true asset to the cause", "I'm not sure how loyal she is to the cause, considering that she is not South African.");
    */
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
