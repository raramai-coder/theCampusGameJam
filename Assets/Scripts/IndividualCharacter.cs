using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualCharacter : MonoBehaviour
{
    [SerializeField] private Character character;
    // Start is called before the first frame update
    void Start()
    {
        Character currentCharacter = character;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Call()
    {

    }

    private void DisplayQuestions(int questionNum)
    {
        //questionText = character.questions[questionNum];
    }

    private void AskQuestions()
    {

    }

    private void AskAbout()
    {

    }

    private void Report()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (character.decoy)
        {
            gameManager.won = true;
        }
        else
        {
            gameManager.won = false;
        }
    }
}
