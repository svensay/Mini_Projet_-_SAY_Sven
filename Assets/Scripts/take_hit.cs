using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class take_hit : MonoBehaviour
{
    public Slider life;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("missile"))
        {
            life.value = life.value - 1;
        }

        if(life.value == 0)
        {
            SceneManager.LoadScene(6);
        }
    }
}
