using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualCharacter : MonoBehaviour
{
    [SerializeField] private Character character;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
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

    private void Call()
    {

    }

    private void DisplayQuestions()
    {

    }

    private void AskQuestions()
    {

    }

    private void AskAbout()
    {

    }

    public void Report()
    {
        
        gameManager.currentCharacter = character;
        gameManager.Report();
    }
}
