using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberColorReset : MonoBehaviour
{
    public MeshRenderer three_a;
    public MeshRenderer three_b;
    public MeshRenderer three_c;
    public Material mat;
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Player")
        {
            three_a.material = mat;
            three_a.gameObject.GetComponent<parentScript>().Atriggered= false;
            three_b.material = mat;
            three_b.gameObject.GetComponent<parentScript>().Atriggered = false;
            three_c.material = mat;
            three_c.gameObject.GetComponent<parentScript>().Atriggered = false;

        }
    }
}
