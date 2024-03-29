﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ennemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
