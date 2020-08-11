using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// FF006A
public class FacePlaneController : MonoBehaviour
{
    
    public float degToRotate;
    GameObject[] planes;
    private Vector3 mousePos;
    private Touch touch;

    void Start()
    {
        
    }

    void OnMouseDown() {
      Debug.Log("touched somebody");
      Debug.Log(this);
    }

    public void Rotate(){
        // Debug.Log("ROTATING");
    }

    void FixedUpdate()
    {

    }
}
