using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Objects : MonoBehaviour
{
    private bool firstInteraction = false;
    private string thisObject;

    public bool indicatorActive = false;

    [SerializeField] private TextMeshProUGUI objectText;
    [SerializeField] public GameObject interactionIndicator;
    [SerializeField] public GameObject textDisplay;

    //private FirstPersonController firstPersonController;

    // Start is called before the first frame update
    void Start()
    {
        thisObject = this.name;
        interactionIndicator.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited");
    }

    public void ActivateIndicator()
    {
        interactionIndicator.SetActive(true);
    }

    public void DisplayStory()
    {
        textDisplay.SetActive(true);
        DisplayInteractionText(firstInteraction);

        if (firstInteraction)
        {
            //DisplayInteractionText(firstInteraction);
            firstInteraction = false;
        }
    }


    private void DisplayInteractionText(bool currentInteraction)
    {
        string textToDisplay;
        
        if (currentInteraction)
        {
            textToDisplay = DisplayFirstText();
        }
        else
        {
           textToDisplay = DisplaySecondText();
        }

        objectText.text = textToDisplay;
    }

    private string DisplayFirstText()
    {
        switch (thisObject)
        {
            case "Bible":
                return "James delights himself in reading the bible and is a firm believer that all the answers are stored in there. He's always got it with him.";
            case "Radio":
                return "The message delivered by OR Tambo is seen to have much impact on the people of colour in South Africa.The notion of freedom and war seems to sit rather well with action oritneted young man, Bandile as he switched the previous station to pay close attention to the provocative words of Tambo. ";
            case "JazzRecord":
                return "Jazz is seen as revolutionary as its improvisation allows for unprecedented freedom of expression through music. Kalu was seen turning up the volume and humming to the tune.";
            case "Handgun":
                return "In South Africa, black people are prohibited from owning guns. However, as a means of protecting one's self from the terrors that could arise at any given time, Thandi always makes sure that her gun is fully loaded in case she needs to protect herself no matter where she is. This gun is also seen to have been manufactured outside of South Africa. ";
            case "BoxingGlove":
                return "Together with other sports, boxing is a protogonist in the dimantle of apartheid as many young black males seek to share their talent witht the world. This one boxing love belongs to Roli who misplaced the other while crossing the river and so his dreams of boxing professionally slipped away.   ";
            case "ContrabanPaper":
                return " The letter reads as following, 'Sawubona boetie. I hope everything is okay. I don't have much time to speak but I hope all is well. I hope those inmates are giving you too much trouble. Hai, also you and being a prison warden. Mama is still not happy. But I'm safe. You keep safe. Roli";
            case "PoliceBaton":
                return "Batons are considered'impact weapons' and have been used to inflict beatings as a means of punishment and deliver unjust treatment. This item was stolen by Thandi as a way of stripping the oppressors of their power";
            case "DrumMagazine":
                return "Mariam Makeba contributes to the fight against the government through the messages of her songs, tours and concerts that end in political rallies. Kalu was last seen reading the article about her, as he seems to not only have a fascination with jazz but with her too. ";
            default:
                return "No information to display on Object.";
        }
        
    }

    private string DisplaySecondText()
    {
        switch (thisObject)
        {
            case "Bible":
                return "It appears to be that portion of a page of the bible has been ripped. The main guilty party thought to be is Thandi as she was seen utilizing an atypical sort of paper to roll her tobacco.";
            case "Radio":
                return "All of a sudden the voice of OR Tambo disappears as James changes the radio station for something more suitable for his taste. ";
            case "JazzRecord":
                return "Bandile carefully takes the record out of the record player and puts it away.";
            case "Handgun":
                return "Roli - There's a certain thrill and feeling of fear when holding something as dangerous as a handgun. Roli experienced thris while inspecting the hazardous weapon while thinking about how his brother is around such weapons all the time.";
            case "BoxingGlove":
                return "Even though he's a lot more unfit than he was, he still uses one glove and tries to remember some techniques.";
            case "ContrabanPaper":
                return "A letter was written by James but no one seems to know who the letter is written for as James refuses to share any detail.";
            case "PoliceBaton":
                return "This serves as a reminder to Roli about the the position or type of occupation his brother has to endure.";
            case "DrumMagazine":
               case   "Mariam":
                return
                    "The article states that Jazz became a political outletfor black musicians and for some, upward mobility and a possibilty to enchance and entrenched clss barriers. Kalu gives this a good and deeper read and in sinspired";
            default:
                return "No information to display on Object.";
        }

    }


    /*// Update is called once per frame
    void Update()
    {
        
    }*/

   
}
