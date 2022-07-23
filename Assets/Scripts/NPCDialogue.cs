using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    PlayerDialogue PlayerDialogue;
    DialogueUI DialogueUI;

    [SerializeField]
    TextMeshProUGUI OptionBtnText1;
    [SerializeField]
    TextMeshProUGUI OptionBtnText2;
    [SerializeField]
    TextMeshProUGUI OptionBtnText3;

        [SerializeField]
    TextMeshProUGUI OptionBtnText4;
        [SerializeField]
    TextMeshProUGUI OptionBtnText5;

    bool question1full;
    bool question2full;

    void Start()
    {
        PlayerDialogue = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDialogue>();
        DialogueUI = GameObject.FindGameObjectWithTag("Canvas").GetComponent<DialogueUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(DialogueUI.calledBandile == 0)
        {
            OptionBtnText1.text = PlayerDialogue.PlayerGeneralQuestions[1];
            OptionBtnText2.text = PlayerDialogue.PlayerGeneralQuestions[2];
            OptionBtnText3.text = PlayerDialogue.PlayerGeneralQuestions[3];
        }
        else{

            if(question1full == false)
            {
                 if(PlayerDialogue.PlayerGeneralQuestions.ContainsKey(1))
                {
                    OptionBtnText4.text = PlayerDialogue.PlayerGeneralQuestions[1];
                    PlayerDialogue.PlayerGeneralQuestions.Remove(1);
                    question1full = true;
                }
                else if(PlayerDialogue.PlayerGeneralQuestions.ContainsKey(2))
                {
                    OptionBtnText4.text = PlayerDialogue.PlayerGeneralQuestions[2];
                    PlayerDialogue.PlayerGeneralQuestions.Remove(2);
                    question1full = true;
                }
                    else if(PlayerDialogue.PlayerGeneralQuestions.ContainsKey(3))
                {
                    OptionBtnText4.text = PlayerDialogue.PlayerGeneralQuestions[3];
                    PlayerDialogue.PlayerGeneralQuestions.Remove(3);
                    question1full = true;
                }
            }
               

            if(question2full == false)
            {
                if(PlayerDialogue.PlayerGeneralQuestions.ContainsKey(1))
                {
                    OptionBtnText4.text = PlayerDialogue.PlayerGeneralQuestions[1];
                    PlayerDialogue.PlayerGeneralQuestions.Remove(1);
                    question2full = true;
                }
                else if(PlayerDialogue.PlayerGeneralQuestions.ContainsKey(2))
                {
                    OptionBtnText4.text = PlayerDialogue.PlayerGeneralQuestions[2];
                    PlayerDialogue.PlayerGeneralQuestions.Remove(2);
                    question2full = true;
                }
                    else if(PlayerDialogue.PlayerGeneralQuestions.ContainsKey(3))
                {
                    OptionBtnText4.text = PlayerDialogue.PlayerGeneralQuestions[3];
                    PlayerDialogue.PlayerGeneralQuestions.Remove(3);
                    question2full = true;
                }
            }


        }
       
    }
}

