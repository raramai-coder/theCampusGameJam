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

    Dictionary<string, string> ThoughtsAboutKalushi = new Dictionary<string, string>();
    Dictionary<string, string> ThoughtsAboutBandile = new Dictionary<string, string>();
    Dictionary<string, string> ThoughtsAboutJames = new Dictionary<string, string>();
    Dictionary<string, string> ThoughtsAboutThandi = new Dictionary<string, string>();
    Dictionary<string, string> ThoughtsAboutRoli = new Dictionary<string, string>();

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

        RoliQuestions.Add(2, "What happened to the other glove?"); 
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

        KalushiGeneralAnswers.Add(1, "When my brother was sent to prison, the police officers beat my brother to the ground. When the same thing happened to me a few years later, I knew I was going to fight to ensure that never would another innocent black be treated like that again.");
        KalushiGeneralAnswers.Add(2, "Warmonger");

        BandileGeneralAnswers.Add(1, "After witnessing the June 16th Soweto Youth uprising and seeing how over 1000 teenagers/young adults were injured by the police force. I vowed to do everything I could to stop those who have colonised us.");
        BandileGeneralAnswers.Add(2, "Warmonger");

        JamesGeneralAnswers.Add(1, "I heard about what happened at the Soweto Uprsing, and knew that I had to fight for my people.");
        JamesGeneralAnswers.Add(2, "Pacifist");

        ThandiGeneralAnswers.Add(2, "I see how harshly the police treat those of us with black skin and I can't stand back and watch it happen anymore."); 
        ThandiGeneralAnswers.Add(1, "Warmonger");

        RoliGeneralAnswers.Add(2, "I was help captive by a police officer whilst walking home day, he took his pants off and pissed on me. No one should be treated like this."); //check to see it this object has been interacted with
        RoliGeneralAnswers.Add(1, "Warmonger");

        //thoughs about

        ThoughtsAboutKalushi.Add("positive","He received 10 years in prison, but got out 5 years early, no one knows how.");
        ThoughtsAboutKalushi.Add("negative","He's an amazing jazz player, I really enjoy having him around.");

        ThoughtsAboutBandile.Add("positive","I love his photos, you should ask him to take one of you.");
        ThoughtsAboutBandile.Add("negative","He doesn't like music. Don't ever trust a man who doesn't like music.");

        ThoughtsAboutJames.Add("positive","He has strong christian values and sings struggle songs with great fervour!");
        ThoughtsAboutJames.Add("negative","It's a bit suspicious, how he only just joined the ANC");

        ThoughtsAboutThandi.Add("positive","She's a strong yet ruthless fighter, a true beneficiary to the cause");
        ThoughtsAboutThandi.Add("negative","I'm not sure how loyal she is to the cause, considering that she is not South African.");

        ThoughtsAboutRoli.Add("positive","He's a skilled boxer, and I heard that he met with Robert Subukwe in person for legal advice.");
        ThoughtsAboutRoli.Add("negative","He's too sympathetic towards black traitors who guard the prisons.");
    }

  /*  void Update()
    {
        
    }*/
}
