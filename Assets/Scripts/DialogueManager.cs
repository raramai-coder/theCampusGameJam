using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject questionProfile;

    [SerializeField]
    GameObject dialoguePanel;

    private GameManager gameManager;
    public Character currentCharacter;

    [SerializeField]
    TextMeshProUGUI characterName;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();


    }

    public void Question()
    {
        questionProfile.SetActive(true);
        characterName.text = currentCharacter.name;
    }
    // Update is called once per frame
    //void Update()
    //{
       
        
    //}
}
