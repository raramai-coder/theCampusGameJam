using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private Object currentObject;
    [SerializeField]
    Camera mainCam;
    Vector3 lastPos;
    Vector3 lastCamRotation;
    public bool canMove = true;

    private GameManager gameManager;
    [SerializeField] private GameObject playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        currentObject = null;
        gameManager = FindObjectOfType<GameManager>();
    }

    private void SetObject()
    {
        //lalalal
    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5))
        {

             //Debug.Log(hit.transform.gameObject.name);


            if(hit.transform.gameObject.layer == 3)
            {
                //hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

    
            if((Input.GetKeyDown(KeyCode.E)) && (canMove == true)) //or if player presses 'enter'
            {
                   canMove = false;
                Debug.Log("player cannot move");
            }
            else if((canMove == false) && (Input.GetKeyDown(KeyCode.E)))
              {
                canMove = true;
            }

        
        }
    }
}
}
