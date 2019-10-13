using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Retry : MonoBehaviour
{
    public void loadFirstStage()
    {
        SceneManager.LoadScene("first_stage");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
