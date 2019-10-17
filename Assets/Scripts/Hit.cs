using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hit : MonoBehaviour
{
    public Text vie;
    public float x_dep;
    public float y_dep;
    public float z_dep;

    public Material own_Color;

    public IEnumerator changeColor()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
        yield return new WaitForSeconds(3.0f);
        GetComponent<Renderer>().material.color = own_Color.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ennemy") || collision.gameObject.CompareTag("Ennemy_follow") || collision.gameObject.CompareTag("Boss"))
            vie.text = (int.Parse(vie.text) - 1).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("missile_ennemy"))
            vie.text = (int.Parse(vie.text) - 1).ToString();

        if (other.gameObject.CompareTag("life"))
        {
            Debug.Log("LIFE");
            vie.text = (int.Parse(vie.text) + 1).ToString();
            Destroy(other.gameObject);
            StartCoroutine(changeColor());
        }
    }

    private void Update()
    {
        if (int.Parse(vie.text) <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(5);
        }
    }
    void FixedUpdate()
    {
        if (transform.position.y <= 0)
        {
            transform.position = new Vector3(x_dep, y_dep, z_dep);
            vie.text = (int.Parse(vie.text) - 1).ToString();
        }
    }
}
