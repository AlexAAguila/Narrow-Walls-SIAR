using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Day1_Script : MonoBehaviour {
    public float time, h;
    public float FadeOut_after_seconds;
    public GameObject gameObject_Animation, dad,child,voice, v2,woman, trans;
    public GameObject BlackFade;
    //public Animation dfd;
    Animator anim, a2, animFade;
   // Animator animFade;
    private Scene scene;
    gameManager GameManager;


    // Use this for initialization
    void Start () {
        anim = gameObject_Animation.GetComponent<Animator>();
        a2 = gameObject_Animation.GetComponent<Animator>();
         animFade = BlackFade.GetComponent<Animator>();
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<gameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //increment variable "time" over time
        time += Time.deltaTime;
        a2.SetFloat("timer", time);

        //if  time is larger than 10
        if (time > 10)
        {
            //anim.SetBool("loopOnce", true);

            //set this animation condition as true
            v2.SetActive(true);

        }

        // separate timer for time variable "h"
        // "h" variable triggers position movement of NPC
        if (time > 25)
        {
            h += Time.deltaTime;
            anim.SetFloat("timer2", h);

            if (h > 10)
            {
                //anim.SetBool("loopOnce", true);

                voice.SetActive(true);

            }
            if(h > 34)
            {
              //  woman.transform.Translate(GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime);
            }
        }
        if (time > 99)
        {
            trans.SetActive(true);
        }

        // after 104 seconds has passed, load in Day2
        if (time > 104)
        {
            SceneManager.LoadScene("Day2");
        }

        if (time > FadeOut_after_seconds) {
            animFade.SetBool("FadeOut", true);  
        }
    }
}
