using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerate : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();
    private int borderX = 1000;
    private int borderZ = 1000;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    public GameObject prefab5;
    public GameObject prefab6;
    public GameObject prefab7;
    public GameObject prefab8;
    public GameObject prefab9;
    public GameObject prefab10;
    public GameObject prefab11;
    public GameObject prefab12;
    public GameObject prefab13;
    public GameObject prefab14;
    public GameObject prefab15;
    public GameObject prefab16;
    public GameObject prefab17;
    public GameObject prefab18;
    public GameObject prefab19;
    public GameObject prefab20;
    public GameObject prefab21;
    public GameObject prefab22;
    public GameObject prefab23;
    public GameObject prefab24;
    public GameObject prefab25;
    public GameObject prefab26;
    public GameObject prefab27;
    public GameObject prefab28;
    public GameObject prefab29;
    public GameObject prefab30;
    public GameObject prefab31;
    public GameObject prefab32;
    public GameObject prefab33;
    public GameObject prefab34;
    public GameObject prefab35;
    public GameObject prefab36;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i<=36; i++)
        {
            string number = i.ToString();
            prefabList.Add(this.GetType().GetField("prefab" + i).GetValue(this) as GameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate(int repititons)
    {
        for(int i =0; i < repititons; i++)
        {
            int prefabIndex = UnityEngine.Random.Range(0, 35);
            GameObject pref = prefabList[prefabIndex];
            float YValue = pref.GetComponent<moveWithMouse>().rounding;
            Vector3 location = new Vector3(UnityEngine.Random.Range(0, borderX),YValue, UnityEngine.Random.Range(0, borderZ));
            Instantiate(pref, location, transform.rotation);
        }
        
    }
}
