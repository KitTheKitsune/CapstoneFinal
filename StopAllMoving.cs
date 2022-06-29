using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StopAllMoving : MonoBehaviour
{
   
    GameObject[] allObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void findAllStop()
    {
        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject go in this.allObjects)
        {
            if (go.activeInHierarchy)
            {
                try {
                    go.GetComponent<moveWithMouse>().setDoneMoving();
                } catch (Exception e) {
                    print("error");
                };
                
            }
        }
    }
}
