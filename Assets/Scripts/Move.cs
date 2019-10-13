using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 50f;
    public float horizontalSpeed = 2.0f;
    public Rigidbody other;
    public Transform pos;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Awake()
    {
        other = GetComponent<Rigidbody>();
        pos = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            //Debug.Log("Escape");

        }

        float h = horizontalSpeed * Input.GetAxis("Mouse X");

        transform.Rotate(0, h, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            other.AddForce(new Vector3(0, 3.5f, 0), ForceMode.Impulse);
    }
}
