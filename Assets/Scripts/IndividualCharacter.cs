using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualCharacter : MonoBehaviour
{
    [SerializeField] public Character character;

    private GameManager gameManager;
    private DialogueManager dialoguemanager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        dialoguemanager = FindObjectOfType<DialogueManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayNotes()
    {
        gameManager.currentCharacter = character;
        gameManager.DisplayCharacterNotes();
        //Debug.Log(gameManager.currentCharacter.name);
    }

    public void Call()
    {
        gameManager.currentCharacter = character;
        ///++character.calls;
        dialoguemanager.currentCharacter = character;
        dialoguemanager.Question();
        
    }

    private void DisplayQuestions()
    {
        
    }

    public string AnswerQuestions(int questionAsked)
    {
        return null;
    }

    public string AskAbout()
    {
        string answer;
        if(character.numOfTimeAskedAbout == 0)
        {
            answer = character.thoughts[1];
        }
        else
        {
            answer = character.thoughts[2];
        }
        ++character.numOfTimeAskedAbout;
        ++character.calls;

        return answer;
    }

    public void Report()
    {
        
        gameManager.currentCharacter = character;
        gameManager.Report();
    }
}
