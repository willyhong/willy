﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void OnStartGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName);//讀取場景名稱

    }
}
