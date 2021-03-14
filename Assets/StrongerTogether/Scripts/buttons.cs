using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{

 public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

 public void quit()
    {
        Application.Quit();
        Debug.Log("Application Exiting");
    }

 public void back()
    {
        SceneManager.LoadScene("Menu");
    }

}
