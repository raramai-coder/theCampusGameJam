using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
  
    public bool canMove = true;

    private GameManager gameManager;
    private LayerMask otherLayers;
    [SerializeField] private GameObject playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        //currentObject = null;
        gameManager = FindObjectOfType<GameManager>();
        otherLayers = (1 << 3);
    }

    private void SetObject()
    {
        //lalalal
    }

    // Update is called once per frame
    void Update()
    {
        
        var ray = new Ray(this.transform.position, this.transform.forward);
        
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity,otherLayers))
        {

            //Debug.Log(hit.transform.gameObject.name);
            Debug.DrawRay(this.transform.position, this.transform.forward * hit.distance, Color.red);

            if (hit.transform.gameObject.layer == 3)
            {
                //hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

                hit.transform.gameObject.GetComponent<Objects>().indicatorActive = true;
                hit.transform.gameObject.GetComponent<Objects>().ActivateIndicator();

                if ((Input.GetKeyDown(KeyCode.E)) && (canMove == true)) //or if player presses 'enter'
                {
                    //Debug.Log("player cannot move");
                    canMove = false;
                    Movement();
                    hit.transform.gameObject.GetComponent<Objects>().DisplayStory();

                }
                else if ((canMove == false) && (Input.GetKeyDown(KeyCode.E)))
                {
                    canMove = true;
                    Movement();
                    hit.transform.gameObject.GetComponent<Objects>().textDisplay.SetActive(false);
                }
            }

        }
        else
        {
            gameManager.DisableInteractableIndicators();
        }
    }

    private void Movement()
    {
        gameManager.ControlMovement();
    }
}
