using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{

    private string name;
    private bool decoy;
    private int calls;
    private int numOfTimeAskedAbout;
    private Dictionary<int, string> questions;
    private Dictionary<int, string> answers;
    private Dictionary<int, string> thoughts;
    private List<int> availableQuestions;

    public Character(string name,bool decoy,string personalQuestion1, string personalQuestion2, string answer1, string answer2, string answer3, string answer4, string thought1, string thought2)
    {
        this.name = name;
        this.decoy = decoy;

        SetQuestions(personalQuestion1,personalQuestion2);
        SetAnswers(answer1,answer2,answer3,answer4);
        SetThoughts(thought1,thought2);
    } 

    private void SetThoughts(string thought1,string thought2)
    {
        thoughts.Add(1,thought1);
        thoughts.Add(2, thought2);
    }

    private void SetAnswers(string answer1, string answer2, string answer3, string answer4)
    {
        questions.Add(1, answer1);
        questions.Add(2, answer2);
        questions.Add(3, answer3);
        questions.Add(4, answer4);
    }

    private void SetQuestions(string question4,string question5)
    {
        questions.Add(1, "What made you want to join Umkhonto we Sizwe?");
        questions.Add(2, "Are you more of a pacifist or a warmonger?");
        questions.Add(3, question4);
        questions.Add(4, question5);
        questions.Add(5, "Ask about another person.");
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

    private void Report()
    {

    }
}
