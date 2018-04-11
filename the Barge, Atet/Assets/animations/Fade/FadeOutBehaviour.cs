using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeOutBehaviour : MonoBehaviour {

    public int index;
    public string levelName;

    public Image black;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Fading());   
    }

    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
    }
}
