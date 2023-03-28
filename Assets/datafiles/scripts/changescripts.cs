using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescripts : MonoBehaviour
{
    public void openapp()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void exitapp()
    {
        Application.Quit();
    }

    public void back()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
