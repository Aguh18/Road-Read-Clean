﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void mulaiGame(){
        SceneManager.LoadScene("Main");
        
    }

    public void quitGAme(){
        Application.Quit();
    }
}
