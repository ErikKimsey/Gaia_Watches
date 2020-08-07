using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlaneController : MonoBehaviour
{
    GameObject[] planes;
    public float degToRotate;
    
    void Start()
    {
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
