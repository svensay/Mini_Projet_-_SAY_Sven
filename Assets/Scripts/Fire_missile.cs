using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_missile : MonoBehaviour
{
    public Rigidbody missilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody rocketIntance;
            rocketIntance = Instantiate(missilePrefab,transform.position,transform.rotation) as Rigidbody;
            rocketIntance.AddForce(transform.forward * 3000);
        }
    }
}
