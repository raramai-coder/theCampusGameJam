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

    // Start is called before the first frame update
    void Start()
    {
        PlayerDialogue = GameObject.FindGameObjectWithTag("Canvas").GetComponent<PlayerDialogue>();
        ChoosePlayerPanel= GameObject.FindGameObjectWithTag("PlayerPanel");
        PanelQ1= GameObject.FindGameObjectWithTag("PanelQ1");
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
}

