using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameObject Page1;
    GameObject Page2;
    GameObject Page3;

    GameObject Introduction;
    GameObject Instruction;
    // Start is called before the first frame update
    void Start()
    {

        Scene scene = SceneManager.GetActiveScene();

        Page1 = GameObject.FindGameObjectWithTag("Page1");
        Page2 = GameObject.FindGameObjectWithTag("Page2");
        Page3 = GameObject.FindGameObjectWithTag("Page3");

        Introduction = GameObject.FindGameObjectWithTag("Introduction");
        Instruction = GameObject.FindGameObjectWithTag("Instructions");

        if(scene.name == "Introduction")
        {
            Instruction.SetActive(false);
        }
        else if(scene.name == "Credits")
        {
            Page2.SetActive(false);
            Page3.SetActive(false);
        }
    
    }

       public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Introduction.SetActive(true);
        Instruction.SetActive(false);
    }

    public void goToInstruction()
    {
        Introduction.SetActive(false);
        Instruction.SetActive(true);
    }


    public void goBackToIntro()
    {
        Introduction.SetActive(true);
        Instruction.SetActive(false);
    }

        public void goToCredits()
    {
        SceneManager.LoadScene("Credits");
        Page1.SetActive(true);
        Page2.SetActive(false);
        Page3.SetActive(false);
    }

      public void goToPage2()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
        Page3.SetActive(false);
        
    }

        public void goToPage3()
    {
        Page1.SetActive(false);
        Page2.SetActive(false);
        Page3.SetActive(true);
    }

    public void goToFactsPage()
    {
        SceneManager.LoadScene("ExtraInfo");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
