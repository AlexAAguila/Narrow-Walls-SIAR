using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {

    // Use this for initialization



    float maxDistance = 1000;

    void Start () {


	}




    //check for objects with tag Destroyable, if raycast hits said object with collider, it will be destoryed. 
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position, fwd * 1000, Color.green);

        RaycastHit hit;

        if (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) > 0.0f)
        {

            if (Physics.Raycast(transform.position, fwd, out hit, maxDistance) && hit.transform.tag == "Destroyable")
            {
                print("This object can be destroyed");
                Destroy(hit.transform.gameObject);

            }
        }
    }

    /* void FixedUpdate()
     {
         RaycastHit hit;

         if (Physics.Raycast(transform.position, -Vector3.up, out hit))
             print("Found an object - distance: " + hit.distance);
     }

     */


    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
       
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "MyGameObjectTag")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(other.gameObject);
        }
    }




}
