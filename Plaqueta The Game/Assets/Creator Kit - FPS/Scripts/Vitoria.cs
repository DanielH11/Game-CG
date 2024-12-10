using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Vitoria : MonoBehaviour
{
    public bool coagulationFlag;//Flag de ferida fechada
    public bool genocidioFlag;//Flag de todos inimigos mortos
    public String pr�ximaFase;//Fase a ser carregada
    public int tempoDeLoad=5;

    void Update()
    {
        coagulationFlag = GameObject.Find("Plaquetas").GetComponent<MostrarObjetos>().coagulationFlag;
        genocidioFlag = GameObject.Find("Inimigos").GetComponent<Genoc�dio>().genocidioFlag;
        if(coagulationFlag&&genocidioFlag)
        {
            Debug.Log("Pr�ximo n�vel");
            StartCoroutine(NextLevel());
        }
    }
    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(tempoDeLoad);
        int score = GameObject.Find("GameSystem").GetComponent<GameSystem>().Score;
        StaticData.Score = StaticData.Score + score;
        Debug.Log(StaticData.Score);
        SceneManager.LoadScene(pr�ximaFase);
    }
}