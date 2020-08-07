using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlaneController : MonoBehaviour
{
    
    public float degToRotate;
    GameObject[] planes;
    private Vector3 mousePos;
    private Touch touch;

    void Start()
    {
        CollectAllPlanes();
    }

    private void CollectAllPlanes(){
        planes = GameObject.FindGameObjectsWithTag("face_plane");
        Debug.Log(planes[0]);
    }

    public void RotatePlanes(){
        Debug.Log("ROTATING");
    }

    void FixedUpdate()
    {

    }
}
