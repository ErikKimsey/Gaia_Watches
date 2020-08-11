using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private FacePlaneController planeController;
    private RaycastHit hit;
    private Vector3 mousePos;
    private Touch touch;

    void Start()
    {
        // planeController = GetComponent<FacePlaneController>();
    }

    private void HandleTouch(Vector3 _touch){
      _touch.z = 10f;
      Vector3 worldTouchPos;
      worldTouchPos = Camera.main.ScreenToWorldPoint(_touch);
      FindNearestObject(worldTouchPos);

    }

    private void FindNearestObject(Vector3 _touch){
      Ray ray = Camera.main.ScreenPointToRay(_touch);
      if(Physics.Raycast(ray, out hit)){
        Debug.Log(hit.collider.name);
      }
    }

    private void GetTouches(){
        if(Input.touchCount > 0){
            touch = Input.GetTouch(0);
            HandleTouch(touch.position);
        } else if (Input.GetMouseButton(0)){
            mousePos = Input.mousePosition;
            HandleTouch(mousePos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetTouches();
    }
}
