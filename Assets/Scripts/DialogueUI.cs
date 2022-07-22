using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    PlayerDialogue PlayerDialogue;
    GameObject ChoosePlayerPanel;
    GameObject PanelQ1;

    [SerializeField]
    Button JamesBtn;
    [SerializeField]
    Button ThandiBtn;
    [SerializeField]
    Button KaliBtn;
    [SerializeField]
    Button RoliBtn;
    [SerializeField]
    Button BandileBtn;

    //tracks number of times a person was called
    public int calledJames = 0;
    public int calledThandi = 0;
    public int calledKali = 0;
    public int calledRoli = 0;
    public int calledBandile = 0;

//tracks which person the player has called
    public bool callJames = false;
    public bool callThandi = false;
    public bool callKali = false;
    public bool callRoli = false;
    public bool callBandile = false;

    GameManager GameManager;

    // Start is called before the first frame update
    void Start()
    {
        PlayerDialogue = GameObject.FindGameObjectWithTag("Canvas").GetComponent<PlayerDialogue>();
        ChoosePlayerPanel= GameObject.FindGameObjectWithTag("PlayerPanel");
        PanelQ1= GameObject.FindGameObjectWithTag("PanelQ1");
        GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(calledKali >= 2)
        {
            KaliBtn.interactable = false;
        }
        else if(calledBandile >= 2)
        {
            BandileBtn.interactable = false;
        }
          else if(calledJames >= 2)
        {
            JamesBtn.interactable = false;
        }
          else if(calledThandi >= 2)
        {
            ThandiBtn.interactable = false;
        }
          else if(calledRoli >= 2)
        {
            RoliBtn.interactable = false;
        }
    }

        //question2Panel where user picks NPC to interogate

    public void callJamesOption()
    {
        callJames = true;
        openNextPanel();
    }

      public void callThandiOption()
    {
        callThandi = true;
        openNextPanel();
    }

      public void callKaliOption()
    {
        callKali = true;
        openNextPanel();
    }

      public void callRoliOption()
    {
        callRoli = true;
        openNextPanel();
    }

      public void callBandileOption()
    {
        callBandile = true;
        calledBandile += 1;
        openNextPanel();
    }

    void openNextPanel()
    {
        ChoosePlayerPanel.SetActive(false);
        PanelQ1.SetActive(true);
    }

    //question2Panel with questions

    //  public void Q1()
    //         {
    //                 Roli.Answwer(1); 
    //         }

    //         public void Q2()
    //         {
    //             Character.Answer(2);
    //         }

    //         public void Q3()
    //         {
    //             Character.Answwer(3);
    //         }

    //         public void Q4()
    //         {
    //             Character.Answwer(4);
    //         }

    //         public void Q5()
    //         {
    //             Character.Answwer(5);
    //         }
    }

