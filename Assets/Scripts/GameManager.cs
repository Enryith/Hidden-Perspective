﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Maze mazePrefab;

    private Maze mazeInstance;

    void Start () {
        BeginGame();
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RestartGame();
        }
    }

    private void BeginGame()
    {
        mazeInstance = Instantiate(mazePrefab) as Maze;
        mazeInstance.name = "Maze Runner";
        mazeInstance.transform.localScale = new Vector3(2f, 2f, 2f);
        //StartCoroutine(mazeInstance.Generate());
        mazeInstance.Generate();
    }

    private void RestartGame()
    {
        StopAllCoroutines();
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }
}
