﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadAft1Sec", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(1);
    }
}
