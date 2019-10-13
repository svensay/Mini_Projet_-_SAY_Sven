using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class appear : MonoBehaviour
{
    public Light l;
    public GameObject ennemy;
    public Slider sl;

    // Update is called once per frame
    void Update()
    {
        if (l.intensity >= 1)
        {
            ennemy.SetActive(true);
            sl.gameObject.SetActive(true);
        }
    }
}
