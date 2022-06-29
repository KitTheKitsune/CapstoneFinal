using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInstantiator : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleActive()
    {
        button1.SetActive(!button1.activeInHierarchy);
        button2.SetActive(!button2.activeInHierarchy);
        button3.SetActive(!button3.activeInHierarchy);
        button4.SetActive(!button4.activeInHierarchy);
        button5.SetActive(!button5.activeInHierarchy);
        button6.SetActive(!button6.activeInHierarchy);
        button8.SetActive(!button8.activeInHierarchy);
        button7.SetActive(!button7.activeInHierarchy);
        button9.SetActive(!button9.activeInHierarchy);
        button10.SetActive(!button10.activeInHierarchy);
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
