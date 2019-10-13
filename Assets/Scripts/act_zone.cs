using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act_zone : MonoBehaviour
{
    public GameObject porte;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && porte != null)
        {
            Destroy(porte);        
        }
    }
}
