using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_door : MonoBehaviour
{
    public GameObject door;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && door != null)
        {
            door.SetActive(true);
        }
    }
}
