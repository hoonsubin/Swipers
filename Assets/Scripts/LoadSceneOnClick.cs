﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    public void LoadByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadTestScene()
    {
        SceneManager.LoadScene("SampleScene");
        
        
    }

    public void LoadPlayerOption()
    {
        SceneManager.LoadScene("PlayerSelect");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("TitleMenu");
    }
}
