using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Rigidbody missilePrefab;
    public float eachTime = 0;

    // Update is called once per frame
    void Update()
    {
        eachTime += Time.deltaTime;
        if (eachTime >= 1)
        {
            Rigidbody rocketIntance;
            rocketIntance = Instantiate(missilePrefab, transform.position, transform.rotation) as Rigidbody;
            rocketIntance.AddForce(transform.forward * 3000);
            eachTime = 0;
        }
    }
}
