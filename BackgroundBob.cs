using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBob : MonoBehaviour
{
    float min = (float)-1000000;
    float max = (float)1000000;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(transform.position.x + (transform.position.x * UnityEngine.Random.Range(min,max)),transform.position.y + (transform.position.y * UnityEngine.Random.Range(min, max)), transform.position.z);
        if (transform.position != target)
        {
            this.transform.position = Vector3.MoveTowards(transform.position, target, 1 * Time.deltaTime);
        }
    }
}
