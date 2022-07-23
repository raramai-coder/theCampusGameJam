using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject questionProfile;



    //[SerializeField]
    //GameObject dialoguePanel;

    private GameManager gameManager;
    public Character currentCharacter;
    public PlayerDialogue playerdialogue;
    
    
   
    

    [SerializeField]
    TextMeshProUGUI characterName;

    [SerializeField]
    GameObject questionPrefab;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        


    }

    public void Question()
    {
        questionProfile.SetActive(true);
        characterName.text = currentCharacter.name;
    }

   

    public void DisplayQuestions()
    {
        int i = 0;
       foreach (KeyValuePair<int, string> dicQuestions in currentCharacter.questions)
        {
            i++;
           GameObject obj =  Instantiate(questionPrefab);
            Button button = obj.GetComponent<Button>();
            button.GetComponentInChildren<TextMeshProUGUI>().text = currentCharacter.questions[i];
        }
    }
    // Update is called once per frame
    //void Update()
    //{
       
        
    //}
}
