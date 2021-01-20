using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displacementControl : MonoBehaviour {

    public float displacementAmount;
    public ParticleSystem explosionParticles;
    //MeshRenderer meshRenderer;
    SkinnedMeshRenderer meshRenderer;
	// Use this for initialization
	void Start () {
        meshRenderer = GetComponent<SkinnedMeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        displacementAmount = Mathf.Lerp(displacementAmount, 0, Time.deltaTime);
        meshRenderer.material.SetFloat("_Amount", displacementAmount);

        if (Input.GetButtonDown("Jump")) {
            displacementAmount += 0.5f;
            explosionParticles.Play();
        }
		
	}
}
