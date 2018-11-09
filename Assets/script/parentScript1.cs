using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentScript1 : MonoBehaviour {
    public MeshRenderer mRend;//material renderer of the calligrpahy character
    public Material mat; //material you want to switch to


    public bool Atriggered;
    public bool Btriggered;
    // bool Btriggered;
    // Use this for initialization
    void Start () {
        mRend = gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            //Atriggered = false;
            /*
            if (Atriggered && Btriggered)
            {
                mRend.material = mat; //change the material to the material you wanted it to change to
            }
            else if (Atriggered)
            {
                Atriggered = false;
            }
            */
        }
	}


    public void childTriggered(string name)
    {
        Debug.Log("trigger on parent");
        if (name.Contains ("collider_A") )//&& OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Atriggered = true;
        }
        if (name.Contains ("collider_B") && Atriggered)
        {
            Btriggered = true;
        }
        if (name.Contains ("collider_C") && Atriggered && Btriggered)
        {
            mRend.material = mat; //change the material to the material you wanted it to change to
        }
    }

    /*
    public void childExit(string name)
    {
        if (name == "collider_B")
        {
            Btriggered = false;
        }
    }
    */
}