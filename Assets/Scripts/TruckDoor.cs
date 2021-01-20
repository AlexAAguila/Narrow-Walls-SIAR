using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckDoor : MonoBehaviour {
    public GameObject doorOpen;
    public Vector3 open;
    public float time;
    gameManager GameManager;
    public GameObject light;
    

    // Use this for initialization
    void Start () {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<gameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        //Door sound needs a 3.5 seconds in advance to activate
        if (time > 88)
        {
            //doorOpen.SetActive(true);
            //light.SetActive(true);
        }

        if (time > 86.5)
        {
       
            light.SetActive(true);
        }
        if (time>94.5)
        {
            //time += Time.deltaTime;
            
            this.transform.Translate(GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime);
            //doorOpen.SetActive(true);
            // this.transform.Translate(open);
        }



    }
}
