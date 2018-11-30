using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterColorReset : MonoBehaviour {
    public MeshRenderer water_a;
    public MeshRenderer water_b;
    public MeshRenderer water_c;
    public MeshRenderer water_d;
    public Material mat;
    public void OnTriggerEnter (Collider Col)
    {
        if (Col.tag == "Player")
        {
            water_a.material = mat;
            water_a.gameObject.GetComponent<parentScript1>().Atriggered = false;
            water_a.gameObject.GetComponent<parentScript1>().Btriggered = false;
            water_b.material = mat;
            water_b.gameObject.GetComponent<parentScript1>().Atriggered = false;
            water_a.gameObject.GetComponent<parentScript1>().Btriggered = false;
            water_c.material = mat;
            water_c.gameObject.GetComponent<parentScript>().Atriggered = false;
            water_d.material = mat;
            water_d.gameObject.GetComponent<parentScript>().Atriggered = false;
        }
    }
}
