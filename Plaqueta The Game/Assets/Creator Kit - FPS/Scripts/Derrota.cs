using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Derrota : MonoBehaviour
{
    private float time;
    public float limiteDeTempo=90f;
    public string sceneToLoad;

    // Update is called once per frame
    void Update()
    {
        time = GameObject.Find("GameSystem").GetComponent<GameSystem>().m_Timer;
        if(time > limiteDeTempo)
        {
            Debug.Log("Derrota por tempo");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
