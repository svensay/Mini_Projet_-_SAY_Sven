using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public float amount = 50f;
    public Rigidbody me;

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;

        me.AddTorque(transform.up * h);
    }
}
