using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsText : MonoBehaviour {

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;

    private void Start()
    {
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
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

    public void LoadText1(GameObject clearThis)
    {
        clearThis.SetActive(false);
        text1.SetActive(true);
    }

    public void LoadText2(GameObject clearThis)
    {
        clearThis.SetActive(false);
        text2.SetActive(true);
    }

    public void LoadText3(GameObject clearThis)
    {
        clearThis.SetActive(false);
        text3.SetActive(true);
    }

    public void LoadText4(GameObject clearThis)
    {
        clearThis.SetActive(false);
        text4.SetActive(true);
    }
}
