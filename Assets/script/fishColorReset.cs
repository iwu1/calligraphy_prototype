using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishColorReset : MonoBehaviour
{
    public MeshRenderer fish_a;
    public MeshRenderer fish_b;
    public MeshRenderer fish_c;
    public MeshRenderer fish_d;
    public MeshRenderer fish_e;
    public MeshRenderer fish_f;
    public MeshRenderer fish_g;
    public MeshRenderer fish_h;
    public MeshRenderer fish_i;
    public MeshRenderer fish_j;
    public MeshRenderer fish_k;
    public Material mat;
    public void OnTriggerEnter (Collider Col)
    {
        if (Col.tag == "Player")
        {
            fish_a.material = mat;
            fish_a.gameObject.GetComponent<parentScript>().Atriggered = false;

            fish_b.material = mat;
            fish_b.gameObject.GetComponent<parentScript1>().Atriggered = false;
            fish_b.gameObject.GetComponent<parentScript1>().Btriggered = false;

            fish_c.material = mat;
            fish_c.gameObject.GetComponent<parentScript>().Atriggered = false;

            fish_d.material = mat;
            fish_d.gameObject.GetComponent<parentScript1>().Atriggered = false;
            fish_d.gameObject.GetComponent<parentScript1>().Btriggered = false;

            fish_e.material = mat;
            fish_e.gameObject.GetComponent<parentScript>().Atriggered = false;

            fish_f.material = mat;
            fish_f.gameObject.GetComponent<parentScript>().Atriggered = false;

            fish_g.material = mat;
            fish_g.gameObject.GetComponent<parentScript>().Atriggered = false;

            fish_h.material = mat;
            fish_h.gameObject.GetComponent<parentScript>().Atriggered = false;

            fish_i.material = mat;
            fish_i.gameObject.GetComponent<parentScript>().Atriggered = false;

            fish_j.material = mat;
            fish_j.gameObject.GetComponent<parentScript>().Atriggered = false;

            fish_k.material = mat;
            fish_k.gameObject.GetComponent<parentScript>().Atriggered = false;
        }
    }
}
