﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject MainButtons;
    public GameObject PlayButtons;

    public AudioSource playSource;

    private void Start()
    {
        PlayButtons.active = false;
        playSource = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        playSource.Play();
    }

    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ClearBtn(GameObject clear)
    {
        Destroy(clear);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }

    public void LoadMain()
    {
        PlayButtons.active = false;
        MainButtons.active = true;
    }

    public void LoadPlay()
    {
        PlayButtons.active = true;
        MainButtons.active = false;
    }
}
