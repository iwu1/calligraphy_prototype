using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentScript : MonoBehaviour {
    public MeshRenderer mRend;//material renderer of the calligrpahy character
    public Material mat; //material you want to switch to


    bool Atriggered;
    bool Bpresent;
    // Use this for initialization
    void Start () {
        mRend = gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (Atriggered && Bpresent)
            {
                mRend.material = mat; //change the material to the material you wanted it to change to
            }
            else if (Atriggered)
            {
                Atriggered = false;
            }
        }
	}


    public void childTriggered(string name)
    {
        if (name == "collider_A" && OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Atriggered = true;
        }
        else if (name == "collider_B" && Atriggered)
        {
            Bpresent = true;
        }
    }

    public void childExit(string name)
    {
        if (name == "collider_B")
        {
            Bpresent = false;
        }
    }
}