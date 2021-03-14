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
    public GameObject[] ToHide = new GameObject[5];

    public int KeyCount
    {

        get { return key; }
        set { key = value; }
    }
    void Start()
    {
        LevelComplete = false;
        Portal.SetActive(false);
        ToHide[0].SetActive(true);
        ToHide[1].SetActive(true);
        ToHide[2].SetActive(true);
        ToHide[3].SetActive(true);
        ToHide[4].SetActive(true);
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
            Portal.SetActive(true);
        }

        Keys.text = "TotalGems:" + KeyCount;
    }
    private void LateUpdate()
    {
        KeyCount = GameObject.FindGameObjectsWithTag("Key").Length;
    }

    public void next()
    {
        ToHide[0].SetActive(true);
        ToHide[1].SetActive(false);
    }
    public void pre()
    {
        ToHide[0].SetActive(false);
        ToHide[1].SetActive(true);
    }
    public void cut()
    {
        ToHide[0].SetActive(false);
        ToHide[1].SetActive(false);
        ToHide[2].SetActive(false);
        ToHide[3].SetActive(false);
        ToHide[4].SetActive(false);
    }
}
