using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_System : MonoBehaviour
{
    public TextMeshProUGUI Life;
    public TextMeshProUGUI Redbean;
    public TextMeshProUGUI Bluebean;
    private int LifeC = 3;
    public int lifeCount
    {
        get { return LifeC; }
        set {LifeC = value; }
    }
    private int Red;
    public int redbean
    {
        get { return Red; }
        set { Red = value; }
    }
    private int blue;
    public int bluebean
    {
        get { return blue; }
        set { blue = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        Red = GameObject.FindGameObjectsWithTag("RedBean").Length;
        blue = GameObject.FindGameObjectsWithTag("BlueBean").Length;
    }

    // Update is called once per frame
    void Update()
    {
        Life.text = "Life:" + LifeC;
        Redbean.text = "Beans:" + redbean;
        Bluebean.text = "Beans:" + bluebean;
    }
}
