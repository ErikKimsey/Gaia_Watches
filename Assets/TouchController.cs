using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 touchPosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 || Input.GetMouseButton(0)){
            // Touch touch = Input.GetTouch(0);
            touchPosition = Input.mousePosition;
            Debug.Log(touchPosition);
        }
    }
}
