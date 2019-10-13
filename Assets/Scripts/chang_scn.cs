using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chang_scn : MonoBehaviour
{
    public int stage;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
            SceneManager.LoadScene(stage);
   
    }
}
