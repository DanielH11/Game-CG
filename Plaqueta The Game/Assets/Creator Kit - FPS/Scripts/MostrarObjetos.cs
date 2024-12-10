using System;
using UnityEngine;
using System.Collections;

public class MostrarObjetos : MonoBehaviour
{
    public GameObject[] objectsToRender;//Array de objetos a serem renderizados
    public String keyToPress = "Submit";//Tecla a ser pressionada
    public float renderDistance = 0.25f;//Distância de renderização
    public float tempo=1f;
    public bool coagulationFlag = false;

    private void Start()
    {
        //Pegando os objetos filhos
        int childCount = transform.childCount;
        objectsToRender = new GameObject[childCount];
        for (int i = 0; i < childCount; i++)
        {
            objectsToRender[i] = transform.GetChild(i).gameObject;
        }
        DesativarObjetos();
    }
    void DesativarObjetos()
    {
        //Desativando-os
        foreach (GameObject obj in objectsToRender)
        {
            //Ativa o objeto
            obj.SetActive(false);
        }
    }
    IEnumerator AtivarObjetos()
    {
        foreach (GameObject obj in objectsToRender)
        {
            obj.SetActive(true);
            yield return new WaitForSeconds(tempo);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown(keyToPress)&&GameObject.Find("Inimigos").GetComponent<Genocídio>().genocidioFlag)
        {
            Vector3 personagemPosicao = GameObject.Find("Character").transform.position;
            float distance = Vector3.Distance(this.transform.position, personagemPosicao);
            if (distance <= renderDistance)
            {
                StartCoroutine(AtivarObjetos());
                //Ferimento fechado
                coagulationFlag=true;
            }
        }
        if (Input.GetButtonDown("Reset"))
        {
            coagulationFlag = false;
            Debug.Log("Voltar");
            DesativarObjetos();
        }
    }
}
