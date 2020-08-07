using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlaneController 
{
    GameObject[] planes;
    public float degToRotate;

    public void Init(){
        CollectAllPlanes();
    }

    private void CollectAllPlanes(){
        planes = GameObject.FindGameObjectsWithTag("face_plane");
        Debug.Log(planes[0]);
    }

    public void RotatePlanes(){

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
