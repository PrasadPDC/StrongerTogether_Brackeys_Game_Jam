using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI_System : MonoBehaviour
{
    public TextMeshProUGUI Keys;
    [HideInInspector]public bool LevelComplete = false;
    public GameObject GATE;
    public GameObject Portal;
    private int key = 3;
    public int KeyCount
    {
        get { return key; }
        set { key = value; }
    }
    void Start()
    {
        LevelComplete = false;
        Portal.GetComponent<BoxCollider>().enabled = false;

    }

    void Update()
    {
      

        if (LevelComplete)
        {
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(key == 0)
        {
            GATE.GetComponent<BoxCollider>().enabled = false;
            Portal.GetComponent<BoxCollider>().enabled = true;
        }

        Keys.text = "Keys:" + KeyCount;
    }
    private void LateUpdate()
    {
        KeyCount = GameObject.FindGameObjectsWithTag("Key").Length;
    }
}
