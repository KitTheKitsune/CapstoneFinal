using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabInstantiator : MonoBehaviour
{
    public GameObject Prefab;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Prefabmaker()
    {
        Instantiate(Prefab, new Vector3(0, 0, 0), transform.rotation);
    }

}
