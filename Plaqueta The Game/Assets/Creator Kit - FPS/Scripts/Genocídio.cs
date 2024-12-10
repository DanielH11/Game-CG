using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genocídio : MonoBehaviour
{
    public GameObject[] inimigos;
    public int inimigoCount = 0;
    private int childCount;
    public bool genocidioFlag=false;
    // Start is called before the first frame update
    void Start()
    {
        childCount = transform.childCount;
        inimigos = new GameObject[childCount];
        for (int i = 0; i < childCount; i++)
        {
            inimigos[i] = transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(inimigoCount>=childCount)
        {
            genocidioFlag = true;
        }
    }
}
