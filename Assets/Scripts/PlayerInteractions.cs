using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private Object currentObject;
    
    // Start is called before the first frame update
    void Start()
    {
        currentObject = null;
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

             Debug.Log(hit.transform.gameObject.name);


            if(hit.transform.gameObject.layer == 3)
            {
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }

    
            if(Input.GetKeyDown(KeyCode.E)) //or if player 'enter'
            {
               //menu pops up
            }

        }
    }
}
