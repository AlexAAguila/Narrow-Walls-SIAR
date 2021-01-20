using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3Script : MonoBehaviour {
    public float time;
    public GameObject dad,kid, terri,woman, dadvoice, childv, polv, ambi, black;
    bool b;
    //public Animation dfd;
    Animator anim, anim1, anim2, anim3;
    //Calling from the black screen script



    // Use this for initialization
    void Start()
    {
        anim = dad.GetComponent<Animator>();
        anim1=kid.GetComponent<Animator>();
        anim2=terri.GetComponent<Animator>();
        anim3 = woman.GetComponent<Animator>();
      //  black.GetComponent<Black_Screen_Script>().fadeOut();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float h = time;
        anim.SetFloat("timer", time);
        anim1.SetFloat("timer", time);
        anim2.SetFloat("timer", time);
        anim3.SetFloat("timer", time);

        if (time > 10)
        {
            //anim.SetBool("loopOnce", true);
            

            dadvoice.SetActive(true);

        }
        if (time > 29)
        {
            childv.SetActive(true);
            
            


        }

        if (time > 50)
        {
            polv.SetActive(true);
        }
        if(time > 54)
        {
            ambi.SetActive(false);
            Color white = black.GetComponent<MeshRenderer>().material.color;
            white.r = 255;
            white.g = 255;
            white.b = 255;

            black.GetComponent<MeshRenderer>().material.color = white;

        }
        if (time > 96 && time < 97)
        {
            black.GetComponent<Black_Screen_Script>().fadeIn();

        }

    }

}