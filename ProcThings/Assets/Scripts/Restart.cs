using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Restart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void restart()
    {
        Maker.mouseList = new List<GameObject>();
        Maker.catList = new List<GameObject>();
        Application.LoadLevel(0);
    }
}
