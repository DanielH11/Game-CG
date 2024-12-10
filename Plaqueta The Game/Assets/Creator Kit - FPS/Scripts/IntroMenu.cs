using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class IntroMenu : MonoBehaviour
{
    public GameObject texto;
    public GameObject texto2;
    public string sceneToLoad;
    private bool flip=false;
    void Start()
    {
        texto = GameObject.Find("Texto 1");
        texto2 = GameObject.Find("Texto 2");
        texto.SetActive(true);
        texto2.SetActive(false);
    }
    void Update()
    {
        if(Input.GetButtonDown("Submit")&&!flip)
        {
            texto.SetActive(false);
            texto2.SetActive(true);
            flip = true;
        }
        else if (Input.GetButtonDown("Submit")&&flip)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
