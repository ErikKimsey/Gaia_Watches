using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private FacePlaneController planeController;

    private Vector3 mousePos;
    private Touch touch;

    void Start()
    {
        planeController = GetComponent<FacePlaneController>();
    }

    private void GetTouches(){
        if(Input.touchCount > 0){
            touch = Input.GetTouch(0);
            Debug.Log(touch);
            planeController.RotatePlanes();
        } else if (Input.GetMouseButton(0)){
            mousePos = Input.mousePosition;
            Debug.Log(mousePos);
            planeController.RotatePlanes();
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetTouches();
    }
}
