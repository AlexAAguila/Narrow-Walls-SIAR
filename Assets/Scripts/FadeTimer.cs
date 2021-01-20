using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTimer : MonoBehaviour {
    public float time;
    public float FadeOut_after_seconds;
    public GameObject BlackFade;
    Animator animFade;

    // Use this for initialization
    void Start () {
        animFade = BlackFade.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (time > FadeOut_after_seconds)
        {
            animFade.SetBool("FadeOut", true);
        }
    }
}
