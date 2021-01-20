using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelChanger : MonoBehaviour {

    public float FadeOut_startTime;
    public float time;

    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        float h = time;

	}

    public void FadeToLevel(int levelIndex)
    {
        if (time > FadeOut_startTime)
        {
            animator.SetTrigger("FadeOut");
        }
    }

}
