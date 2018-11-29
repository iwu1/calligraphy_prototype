using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_brushScript : MonoBehaviour {
    public MeshRenderer mRend;//material renderer of the calligrpahy character

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            print("touched");
            mRend.enabled = true;
            Destroy(gameObject);
        }
        
    }
}
