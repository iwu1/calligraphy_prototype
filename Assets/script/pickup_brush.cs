using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_brush : MonoBehaviour {
    public MeshRenderer mRend;//material renderer of the calligrpahy character

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "hand")
        {

        }
        
    }
}
