using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider c) //when you touch it
    {
        if (c.gameObject.tag == "Player")
        {
            Debug.Log("triggered " + c.name + this.name);
            parentScript pScript;
            pScript = transform.parent.GetComponent<parentScript>();
            Debug.Log("...working" + pScript);
            pScript.childTriggered(gameObject.name);
        }
    }

    /*void OnTriggerExit(Collider c ) //when you leave it
    {
        if (c.gameObject.tag == "Player")
        {
            Debug.Log("exit " + c.name + this.name);
            parentScript pScript;
            pScript = transform.parent.GetComponent<parentScript>();
        }
    }*/
}
