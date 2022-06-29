using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWithMouse : MonoBehaviour
{
    const float SPEED = 10000f;
    private Vector3 targetPos;
    public bool isMoving;
    public bool doneMove = false;
    const int MOUSE = 1;
    public float rounding = 0f;
    public bool adjusted = false;
    private bool extra = true;
    //public Rotate rot;


    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!doneMove)
        {
            setTargetPosition();
            
        }
        if (isMoving)
        {
            moveObject();
        }
        if (Input.GetMouseButton(MOUSE) && !doneMove)
        {
            doneMove = true;   
        }
    }

    private void OnMouseDown()
    {
        if (doneMove)
        {
            this.doneMove = false;
        }
    }

    public void setTargetPosition()
    {
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if(plane.Raycast(ray,out point))
        {
            targetPos = ray.GetPoint(point);
            isMoving = true;
        }
        doneMove = false;
    }

    void moveObject()
    {
        targetPos = new Vector3(targetPos.x, rounding, targetPos.z);
        //transform.LookAt(targetPos);
        transform.position = Vector3.MoveTowards(transform.position, targetPos, SPEED * Time.deltaTime);
        if(transform.position == targetPos)
        {
            isMoving = false;
        }
        doneMove = false;
    }

    public void setDoneMoving()
    {
        doneMove = true;
    }
}
