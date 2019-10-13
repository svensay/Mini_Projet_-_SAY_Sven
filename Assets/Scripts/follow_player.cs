using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{

    public Transform player_position;
    private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player_position.position, speed*Time.deltaTime);
    }
}
