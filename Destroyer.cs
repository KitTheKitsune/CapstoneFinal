using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public KeyCode keyToDestroy;
    public KeyCode delete;
    public bool selected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (selected && Input.GetKeyDown(delete))
        {
            Destroy(gameObject);
        }
        else if (Input.GetKeyDown(keyToDestroy))
        {
            Destroy(gameObject);
        }
    }

    public void select()
    {
        selected = true;
    }
   
}
