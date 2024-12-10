using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoxCapsule : MonoBehaviour
{

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Controller c = other.GetComponent<Controller>();

        if (c != null)
        {
            Destroy(gameObject);
        }
    }
}
