﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("Game");

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
