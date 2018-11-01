using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentScript : MonoBehaviour {
    public bool Atriggered;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            Atriggered = false;
        }
	}


    public void childTriggered(string name)
    {
        if (name == "collider_A" && OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Atriggered = true;
        } else if (name.Contains("B") && Atriggered && OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("IT WORKED");
        }
    }
}