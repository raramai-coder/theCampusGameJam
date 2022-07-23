using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject questionProfile;
    [SerializeField] TextMeshProUGUI characterName,dialogueNameLabel,dialogueText,askAboutLabel;
    [SerializeField] GameObject questionPrefab,aboutNamePrefab;
    [SerializeField] GameObject dialoguePanel,notebook,askAboutPanel;
    [SerializeField] private List<IndividualCharacter> characters;

    private GameManager gameManager;
    private NoteTaking noteTaking;
    private List<GameObject> buttons,nameButtons;
    private List<string> names;

    public Character currentCharacter;
    public PlayerDialogue playerdialogue;

    [SerializeField]
   IndividualCharacter IndividualCharacter;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        noteTaking = FindObjectOfType<NoteTaking>();
        buttons = new List<GameObject>();
        nameButtons = new List<GameObject>();
        //names = new List<string>() {"Bandile","James","Kalushi","Roli","Thandi" };
    }

    public void AskAbout()
    {
        questionProfile.SetActive(false);
        askAboutPanel.SetActive(true);

        noteTaking.dictionary = 1;

        askAboutLabel.text = "Ask " + currentCharacter.name + " About...";

        if (nameButtons.Count > 0)
        {
            foreach(GameObject obj in nameButtons)
            {
                Destroy(obj);
            }
        }

        foreach (IndividualCharacter cname in characters)
        {
            if (!cname.character.name.Equals(currentCharacter.name) && cname.character.numOfTimeAskedAbout<2)
            {
                GameObject obj = Instantiate(aboutNamePrefab);
                obj.transform.SetParent(askAboutPanel.transform);
                Button button = obj.GetComponent<Button>();
                button.GetComponentInChildren<TextMeshProUGUI>().text = cname.character.name;

                switch (cname.character.name)
                {
                    case "Roli":
                        button.onClick.AddListener(AskAboutRoli);
                        break;
                    case "Kalushi":
                        button.onClick.AddListener(AskAboutKalushi);
                        break;
                    case "Bandile":
                        button.onClick.AddListener(AskAboutBandile);
                        break;
                    case "James":
                        button.onClick.AddListener(AskAboutJames);
                        break;
                    case "Thandi":
                        button.onClick.AddListener(AskAboutThandi);
                        break;
                }

                nameButtons.Add(obj);

            }
        }


    }

    public void AskAboutRoli()
    {
        IndividualCharacter characterAskedAbout;
        string answer = "";
        foreach (IndividualCharacter character in characters)
        {
            if (character.character.name.Equals("Roli"))
            {
                characterAskedAbout = character;
                answer = characterAskedAbout.AskAbout();
                noteTaking.characterToNoteFrom = characterAskedAbout.character;
                break;

            }
        }
        dialogueText.text = answer;
        RemoveQuestion(5);

        
    }

    public void AskAboutKalushi()
    {
        IndividualCharacter characterAskedAbout;
        string answer = "";
        foreach (IndividualCharacter character in characters)
        {
            if (character.character.name.Equals("Kalushi"))
            {
                characterAskedAbout = character;
                answer = characterAskedAbout.AskAbout();
                break;
            }
        }
        dialogueText.text = answer;
        RemoveQuestion(5);
    }

    public void AskAboutBandile()
    {
        IndividualCharacter characterAskedAbout;
        string answer = "";
        foreach (IndividualCharacter character in characters)
        {
            if (character.character.name.Equals("Bandile"))
            {
                characterAskedAbout = character;
                answer = characterAskedAbout.AskAbout();
                noteTaking.characterToNoteFrom = characterAskedAbout.character;
                break;
            }
        }
        dialogueText.text = answer;
        RemoveQuestion(5);
    }

    public void AskAboutJames()
    {
        IndividualCharacter characterAskedAbout;
        string answer = "";
        foreach (IndividualCharacter character in characters)
        {
            if (character.character.name.Equals("James"))
            {
                characterAskedAbout = character;
                answer = characterAskedAbout.AskAbout();
                noteTaking.characterToNoteFrom = characterAskedAbout.character;
                break;
            }
        }
        dialogueText.text = answer;
        RemoveQuestion(5);
    }

    public void AskAboutThandi()
    {
        IndividualCharacter characterAskedAbout;
        string answer = "";
        foreach (IndividualCharacter character in characters)
        {
            if (character.character.name.Equals("Thandi"))
            {
                characterAskedAbout = character;
                answer = characterAskedAbout.AskAbout();
                noteTaking.characterToNoteFrom = characterAskedAbout.character;
                break;
            }
        }
        dialogueText.text = answer;
        RemoveQuestion(5);
    }

    public void Question()
    {
        questionProfile.SetActive(true);
        characterName.text = currentCharacter.name;
        DisplayQuestions();
    }

   public void NextQuestion()
    {
        if (currentCharacter.calls < 2)
        {
            dialoguePanel.SetActive(false);
            Question();
        }
        else
        {
            dialoguePanel.SetActive(false);
            // IndividualCharacter.currentSource.loop = false; 
            //IndividualCharacter.currentSource.Stop();
            //gameManager.currentCharacter.currentSource.Stop();
            //currentCharacter.currentSource.Stop();
            // foreach(IndividualCharacter char in characters){
            //     if(char.character.name.Equals(currentCharacter.name)){
            //         char.character.currentSource.Stop();
            //     }
            // }
        }
    }

    public void DisplayQuestions()
    {
        if (buttons.Count > 0)
        {
            foreach(GameObject button in buttons)
            {
                Destroy(button);
            }
            buttons.Clear();
        }
        
        foreach( int questionKey in currentCharacter.availableQuestions)
        {
            GameObject obj = Instantiate(questionPrefab);
            obj.transform.SetParent(questionProfile.transform);
            Button button = obj.GetComponent<Button>();
            button.GetComponentInChildren<TextMeshProUGUI>().text = currentCharacter.questions[questionKey];

            switch (questionKey)
            {
                case 1:
                    button.onClick.AddListener(Question1);
                    break;
                case 2:
                    button.onClick.AddListener(Question2);
                    break;
                case 3:
                    button.onClick.AddListener(Question3);
                    break;
                case 4:
                    button.onClick.AddListener(Question4);
                    break;
                case 5:
                    button.onClick.AddListener(AskAbout);
                    break;
            }

            buttons.Add(obj);

        }
        
    }

   

    private void RemoveQuestion(int question)
    {
        currentCharacter.availableQuestions.Remove(question);
        dialoguePanel.SetActive(true);
        questionProfile.SetActive(false);
        askAboutPanel.SetActive(false);
        notebook.SetActive(false);
        gameManager.notebookOpen = false;
        dialogueNameLabel.text = currentCharacter.name;
        

    }

    public void Question1()
    {
        string answer = currentCharacter.answers[1];
        //++currentCharacter.calls;
        //Debug.Log(answer);
        dialogueText.text = answer;
        RemoveQuestion(1);
        ++currentCharacter.calls;

        noteTaking.key = 1;
        noteTaking.dictionary = 0;
        noteTaking.characterToNoteFrom = currentCharacter;
    }

    public void Question2()
    {
        string answer = currentCharacter.answers[2];
        //Debug.Log(answer);
        dialogueText.text = answer;
        RemoveQuestion(2);
        ++currentCharacter.calls;

        noteTaking.key = 2;
        noteTaking.dictionary = 0;
        noteTaking.characterToNoteFrom = currentCharacter;
    }

    public void Question3()
    {
        string answer = currentCharacter.answers[3];
        //Debug.Log(answer);
        dialogueText.text = answer;
        RemoveQuestion(3);
        ++currentCharacter.calls;

        noteTaking.key = 3;
        noteTaking.dictionary = 0;
        noteTaking.characterToNoteFrom = currentCharacter;
    }

    public void Question4()
    {
        string answer = currentCharacter.answers[4];
        //Debug.Log(answer);
        dialogueText.text = answer;
        RemoveQuestion(4);
        ++currentCharacter.calls;

        noteTaking.key = 4;
        noteTaking.dictionary = 0;
        noteTaking.characterToNoteFrom = currentCharacter;
    }

    // Update is called once per frame
    //void Update()
    //{


    //}
}
