using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
  

    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
      
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && transform.position.y > .1 && transform.position.y < 20.0)
        {
            transform.Translate(new Vector3(0,0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && transform.position.y < 20.0 && transform.position.y > .1)
        {
            transform.Translate(new Vector3(0,0, speed * Time.deltaTime));
        }
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && transform.position.y > 0.5)
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.Space) && transform.position.y < 20.0)
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * 10, 0);
            transform.Rotate(-Input.GetAxis("Mouse Y") * 10, 0, 0);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,0);
        }

    }
}
