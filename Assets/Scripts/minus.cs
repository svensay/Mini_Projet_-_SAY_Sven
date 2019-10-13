using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus : MonoBehaviour
{
    public Light NO;
    public Light NE;
    public Light SO;
    public Light SE;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && NO.intensity > 0)
        {
            NO.intensity -= 0.2f;
            NE.intensity -= 0.2f;
            SO.intensity -= 0.2f;
            SE.intensity -= 0.2f;
        }
    }
}
