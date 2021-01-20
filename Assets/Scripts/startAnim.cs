using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startAnim : MonoBehaviour {


    public Animator Anime;
    public float MyTime = 0f;
    public Transform radialProgress;

	// Use this for initialization
	void Start () {
        Anime = GetComponent<Animator>();
        radialProgress.GetComponent<Image>().fillAmount = MyTime;    
    }



    public void triggerAnim() {

        Anime.Play("Woman_Animation");
    }
    // Update is called once per frame

    public void Update() {

        //adds seconds to MyTime
        MyTime += Time.deltaTime;

        radialProgress.GetComponent<Image>().fillAmount = MyTime/3;

        if (MyTime >=3f) {
            triggerAnim();
        }
    }


    public void Resetinator() {
        MyTime = 0f;
    }
}
