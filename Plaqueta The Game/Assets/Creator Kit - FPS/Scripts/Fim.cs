using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fim : MonoBehaviour
{
    //[SerializeField]
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        string text = StaticData.Score.ToString();
        texto.text = "Score: " + text;
    }
}
