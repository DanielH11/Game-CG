using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{
    public Genoc�dio contagem;
    // Start is called before the first frame update
    void Start()
    {
        contagem = GameObject.Find("Inimigos").GetComponent<Genoc�dio>();
    }

    // Update is called once per frame
    void OnDisable()
    {
        contagem.inimigoCount++;
    }
}
