using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CreateCharacter", order = 1)]
public class Character : ScriptableObject
{

    [SerializeField] private string name, personalQuestion1, personalQuestion2, answer1, answer2, answer3, answer4, thought1, thought2;
    [SerializeField] public bool decoy = false;
    public int calls;
    public int questionsAsked;
    public int numOfTimeAskedAbout;
    public Dictionary<int, string> questions = new Dictionary<int, string>();
    public Dictionary<int, string> answers = new Dictionary<int, string>();
    public Dictionary<int, string> thoughts = new Dictionary<int, string>();
    public Dictionary<int, string> answersNotes = new Dictionary<int, string>();
    public Dictionary<int, string> thoughtsNotes = new Dictionary<int, string>();
    public List<int> availableQuestions;

    private void OnEnable()
    {
        SetQuestions(personalQuestion1, personalQuestion2);
        SetAnswers(answer1, answer2, answer3, answer4);
        SetThoughts(thought1, thought2);
        calls = 0;
        numOfTimeAskedAbout = 0;
        questionsAsked = 0;
        availableQuestions = new List<int>() { 1, 2, 3, 4, 5 };
    }



    private void SetThoughts(string thought1,string thought2)
    {
        thoughts.Add(1,thought1);
        thoughts.Add(2, thought2);
    }

    private void SetAnswers(string answer1, string answer2, string answer3, string answer4)
    {
        answers.Add(1, answer1);
        answers.Add(2, answer2);
        answers.Add(3, answer3);
        answers.Add(4, answer4);
    }

    private void SetQuestions(string question4,string question5)
    {
        questions.Add(1, "What made you want to join Umkhonto we Sizwe?");
        questions.Add(2, "Are you more of a pacifist or a warmonger?");
        questions.Add(3, question4);
        questions.Add(4, question5);
        questions.Add(5, "Ask about another person.");
    }
    
  
}
