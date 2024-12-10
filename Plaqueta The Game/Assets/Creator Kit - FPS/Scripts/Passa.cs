using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Passa : MonoBehaviour
{
    public int timeToLoad=1;
    public string sceneToLoad;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(timeToLoad);
        SceneManager.LoadScene(sceneToLoad);
    }
}
