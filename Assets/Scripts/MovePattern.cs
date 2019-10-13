using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePattern : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public Transform dest;
    public float moveSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (dest.position.Equals(transform.position))
        {
            if (dest.position.Equals(pos1.position))
            {
                dest = pos2;
            }
            else
            {
                dest = pos1;
            }

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, dest.position, moveSpeed * Time.deltaTime * 0.1f);
        }
    }
}
