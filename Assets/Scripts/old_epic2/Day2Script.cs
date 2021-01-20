using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Day2Script : MonoBehaviour {
    public float time;
    public GameObject voice, soldier, trans,v2;
    Animator anim;
    


    // Use this for initialization
    void Start () {
        anim = soldier.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float h = time;
        anim.SetFloat("timer", time);
        

        if (time > 10)
        {
            voice.SetActive(true);
        }
        if (time > 15)
        {
            v2.SetActive(true);
        }
        if (time > 70)
        {
            trans.SetActive(true);

        }
        if (time > 75)
        {
            SceneManager.LoadScene("Day3");
        }


    }
}
