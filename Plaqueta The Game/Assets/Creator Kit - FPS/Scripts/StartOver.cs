using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOver : MonoBehaviour
{
    public string sceneToLoad = "Intro";
    // Start is called before the first frame update
    void Start()
    {
        StaticData.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
