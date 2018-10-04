using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //if(Input.GetKeyDown())
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entrdo en esfera");
        if (other.GetComponent<ParticleSystem>() != false)
            other.GetComponent<ParticleSystem>().Play();
    }
}
