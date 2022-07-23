using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject questionProfile;
    [SerializeField] TextMeshProUGUI characterName,dialogueNameLabel,dialogueText;
    [SerializeField] GameObject questionPrefab;
    [SerializeField] GameObject dialoguePanel,notebook,askAboutPanel;

    private GameManager gameManager;
    private List<GameObject> buttons;

    public Character currentCharacter;
    public PlayerDialogue playerdialogue;

   

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        buttons = new List<GameObject>();
    }

    public void Question()
    {
        questionProfile.SetActive(true);
        characterName.text = currentCharacter.name;
        DisplayQuestions();
    }

   public void NextQuestion()
    {
        if (currentCharacter.calls < 2)
        {
            dialoguePanel.SetActive(false);
            Question();
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }

    public void DisplayQuestions()
    {
        if (buttons.Count > 0)
        {
            foreach(GameObject button in buttons)
            {
                Destroy(button);
            }
            buttons.Clear();
        }
        
        foreach( int questionKey in currentCharacter.availableQuestions)
       {
            GameObject obj = Instantiate(questionPrefab);
            obj.transform.parent = questionProfile.transform;
            Button button = obj.GetComponent<Button>();
            button.GetComponentInChildren<TextMeshProUGUI>().text = currentCharacter.questions[questionKey];

            switch (questionKey)
            {
                case 1:
                    button.onClick.AddListener(Question1);
                    break;
                case 2:
                    button.onClick.AddListener(Question2);
                    break;
                case 3:
                    button.onClick.AddListener(Question3);
                    break;
                case 4:
                    button.onClick.AddListener(Question4);
                    break;
                case 5:
                    button.onClick.AddListener(AskAbout);
                    break;
            }

                buttons.Add(obj);

        }
        
    }

    public void AskAbout()
    {
        questionProfile.SetActive(false);
        askAboutPanel.SetActive(true);
    }

    private void RemoveQuestion(int question)
    {
        currentCharacter.availableQuestions.Remove(question);
        dialoguePanel.SetActive(true);
        questionProfile.SetActive(false);
        notebook.SetActive(false);
        gameManager.notebookOpen = false;
        dialogueNameLabel.text = currentCharacter.name;
        

    }

    public void Question1()
    {
        string answer = currentCharacter.answers[1];
        //++currentCharacter.calls;
        Debug.Log(answer);
        dialogueText.text = answer;
        RemoveQuestion(1);
        ++currentCharacter.calls;
    }

    public void Question2()
    {
        string answer = currentCharacter.answers[2];
        Debug.Log(answer);
        dialogueText.text = answer;
        RemoveQuestion(2);
        ++currentCharacter.calls;
    }

    public void Question3()
    {
        string answer = currentCharacter.answers[3];
        Debug.Log(answer);
        dialogueText.text = answer;
        RemoveQuestion(3);
        ++currentCharacter.calls;
    }

    public void Question4()
    {
        string answer = currentCharacter.answers[4];
        Debug.Log(answer);
        dialogueText.text = answer;
        RemoveQuestion(4);
        ++currentCharacter.calls;
    }

    // Update is called once per frame
    //void Update()
    //{


    //}
}
