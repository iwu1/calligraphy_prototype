using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript1 : MonoBehaviour {
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
            parentScript1 pScript1;
            pScript1 = transform.parent.GetComponent<parentScript1>();
            Debug.Log("...working" + pScript1);
            pScript1.childTriggered(gameObject.name);
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
