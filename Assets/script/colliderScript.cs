using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour {
    public MeshRenderer mRend;//material renderer of the calligrpahy character
    public Material mat; //material you want to switch to
    public bool triggered = false;
    //public string testChar;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(testChar))
        //{
        //    print("child " + name + " triggered");
        //    transform.parent.GetComponent<parentScript>().childTriggered(gameObject.name);
        //}
	}

    void OnTriggerEnter(Collider c) //when you touch it
    {
        if (c.gameObject.tag == "Player")
        {
            mRend.material = mat; //change the material to the material you wanted it to change to
            Debug.Log("triggered " + c.name + this.name);
            triggered = true;
            transform.parent.GetComponent<parentScript>().childTriggered(gameObject.name);
        }
    }

}
