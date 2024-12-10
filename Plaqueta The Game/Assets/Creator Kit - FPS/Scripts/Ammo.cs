using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    public GameObject ammoPrefab;
    GameObject instance = null;
    public float x;
    public float y;
    public float z;
    private int ammoAmount;

    
    // Update is called once per frame
    void Update()
    {
        GameObject canvas = GameObject.Find("WeaponInfo");
        Transform image = canvas.transform.Find("WeaponBGImage");
        Text ammo = image.GetChild(1).GetComponent<Text>();

        if (Input.GetButtonDown("More")&&instance==null&&int.Parse(ammo.text)<=50)
        {
            instance = Instantiate(ammoPrefab);
            instance.transform.position = new Vector3(x, y, z);
        }
    }
}