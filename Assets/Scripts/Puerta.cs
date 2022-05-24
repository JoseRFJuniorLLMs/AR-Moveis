using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Puerta: MonoBehaviour
{
    public Material[] materiales;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var mat in materiales)
        {
            mat.SetInt("stest", (int)CompareFunction.Equal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    private void OnTriggerStay(Collider collide)
    {
        if (collide.tag != "MainCamera")
        {
            return;
        }

        // fuera
        if (collide.tag == "MainCamera")
        {

            if (transform.position.z > collide.transform.position.z)
            {
                foreach (var mat in materiales)
                {
                    mat.SetInt("stest", (int)CompareFunction.Equal);
                }
            }

            //dentro
            else
            {
                foreach (var mat in materiales)
                {
                    mat.SetInt("stest", (int)CompareFunction.NotEqual);
                }
            }

        }
    }

















}
