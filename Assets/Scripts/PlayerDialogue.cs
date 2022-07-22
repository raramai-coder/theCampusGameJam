using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogue : MonoBehaviour
{
    List<string> NPCs = new List<string>();
    Dictionary<int, string> PlayerGeneralQuestions = new Dictionary<int, string>();

    Dictionary<int, string> KalushiQuestions = new Dictionary<int, string>();
    Dictionary<int, string> BandileQuestions = new Dictionary<int, string>();
    Dictionary<int, string> JamesQuestions = new Dictionary<int, string>();
    Dictionary<int, string> ThandiQuestions = new Dictionary<int, string>();
    Dictionary<int, string> RoliQuestions = new Dictionary<int, string>();

    Dictionary<int, string> KalushiAnswers = new Dictionary<int, string>();
    Dictionary<int, string> BandileAnswers = new Dictionary<int, string>();
    Dictionary<int, string> JamesAnswers = new Dictionary<int, string>();
    Dictionary<int, string> ThandiAnswers = new Dictionary<int, string>();
    Dictionary<int, string> RoliAnswers = new Dictionary<int, string>();

    Dictionary<int, string> KalushiGeneralAnswers = new Dictionary<int, string>();
    Dictionary<int, string> BandileGeneralAnswers = new Dictionary<int, string>();
    Dictionary<int, string> JamesGeneralAnswers = new Dictionary<int, string>();
    Dictionary<int, string> ThandiGeneralAnswers = new Dictionary<int, string>();
    Dictionary<int, string> RoliGeneralAnswers = new Dictionary<int, string>();

    // Start is called before the first frame update
    void Start()
    {
        NPCs.Add("James");
        NPCs.Add("Thandi");
        NPCs.Add("Kali");
        NPCs.Add("Roli");
        NPCs.Add("Bandile");

        //general questions

        PlayerGeneralQuestions.Add(1, "What made you want to join Umkhonte we Sizwe?");
        PlayerGeneralQuestions.Add(2, "What do you think about "); //choice of names exclusing player/person talking to
        PlayerGeneralQuestions.Add(3, "Are you more of a pacifist or a warmonger?");

        //personal questions

        KalushiQuestions.Add(1, "Why was your sentence shortened?");
        KalushiQuestions.Add(2, "What's so great about Jazz?");

        BandileQuestions.Add(1, "Why don't you like music?");
        BandileQuestions.Add(2, "WHy did you join the ANC and not the PAC?");

        JamesQuestions.Add(1, "If you're a pacifisit, why did you join the militiary wing, Umkhonte we Sizwe?");
        JamesQuestions.Add(2, "What was it like growing up in a small rural town?");

        ThandiQuestions.Add(2, "If you're not South Africa, why have you joined the ANC?"); 
        ThandiQuestions.Add(1, "What happened to your parents?");

        RoliQuestions.Add(2, "What happened to the other glove?"); //check to see it this object has been interacted with
        RoliQuestions.Add(1, "How do you not see black officers as traitors?");

//personal answers

        KalushiAnswers.Add(1, "How does that concern you? Mind your own business.");
        KalushiAnswers.Add(2, "He went to prison for stabbing a police officer.");

        BandileAnswers.Add(1, "Stop messing around and focus on your training");
        BandileAnswers.Add(2, "Jazz is revolutionary");

        JamesAnswers.Add(1, "If you're a pacifisit, why did you join the militiary wing, Umkhonte we Sizwe");
        JamesAnswers.Add(2, "It was very religous, but made me the man I am today");

        ThandiAnswers.Add(2, "I like that they're not afraid to fight fire with fire"); 
        ThandiAnswers.Add(1, "My father is South African, he died fighting for the ANC leaving me in an orphanage");

        RoliAnswers.Add(2, "I lost one, whilst crossing over the Limpopo River from South Africa into Mozambique"); //check to see it this object has been interacted with
        RoliAnswers.Add(1, "My brother is a prison warden, they are just doing their jobs.");

        //General answers

        KalushiGeneralAnswers.Add(1, "How does that concern you? Mind your own business.");
        KalushiGeneralAnswers.Add(2, "He went to prison for stabbing a police officer.");
        KalushiGeneralAnswers.Add(3, "He went to prison for stabbing a police officer.");

        BandileGeneralAnswers.Add(1, "What is your full name?");
        BandileGeneralAnswers.Add(2, "Jazz is revolutionary");
        BandileGeneralAnswers.Add(3, "Jazz is revolutionary");

        JamesGeneralAnswers.Add(1, "If you're a pacifisit, why did you join the militiary wing, Umkhonte we Sizwe");
        JamesGeneralAnswers.Add(2, "What was it like growing up in a small rural town");
        JamesGeneralAnswers.Add(3, "What was it like growing up in a small rural town");

        ThandiGeneralAnswers.Add(2, "If you're not South Africa, why have you joined the ANC?"); 
        ThandiGeneralAnswers.Add(1, "What happened to your parents?");
        ThandiGeneralAnswers.Add(3, "What happened to your parents?");

        RoliGeneralAnswers.Add(2, "What happened to the other glove?"); //check to see it this object has been interacted with
        RoliGeneralAnswers.Add(1, "How do you not see black officers as traitors?");
        RoliGeneralAnswers.Add(3, "How do you not see black officers as traitors?");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
