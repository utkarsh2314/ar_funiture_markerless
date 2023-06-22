using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARraycast : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject objectToPlace;

    public Camera arCamera;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);

        if(Input.GetMouseButton(0))
        {
            if(raycastManager.Raycast(ray,hits,TrackableType.Planes))
            {
                Pose hitPose = hits[0].pose;
                Instantiate(objectToPlace, hitPose.position, hitPose.rotation);

            }
        }
    }
}
