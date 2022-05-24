using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARController : MonoBehaviour
{
    public GameObject MyObject;
    public ARRaycastManager RaycastManager;
    public int contador = 0;
    public GameObject Origin;
    public ARPlaneManager myPlanes;


    // Start is called before the first frame update
    void Start()
    {
        myPlanes = Origin.GetComponent<ARPlaneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && contador==0)
        {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();
            RaycastManager.Raycast(Input.GetTouch(0).position,touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

            if (touches.Count > 0) {
                GameObject.Instantiate(MyObject, touches[0].pose.position, touches[0].pose.rotation);
                contador++;
                myPlanes.enabled = false;
            }
                
            
        }

        
    }
}
