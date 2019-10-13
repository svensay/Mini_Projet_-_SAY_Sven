using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Run());
    }

    public IEnumerator Run()
    {
        yield return new WaitForSeconds(5f);
        Application.Quit();
    }
}
