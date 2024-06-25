using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Left Click
        if(Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("Mouse 0 - Left Click");
            
            //Gets the mouse position
            //(0,0) at left bottom
            //(width,height) at top right
            Debug.Log(Input.mousePosition);

            //ScreenToWorldPoint gets World Coordinates
            //would be needed to spawn G.O. at mouse position
            Debug.Log("World Point: " + Camera.main.ScreenToWorldPoint(Input.mousePosition));
            
            //Viewport is a (normalized) size of window
            //(0,0) at bottom left and (1,1) at top right
            Debug.Log("Viewport Point: " + Camera.main.ScreenToViewportPoint(Input.mousePosition));
        }
        //Right Click
        if(Input.GetMouseButtonDown(1)) 
        {
            Debug.Log("Mouse 1 - Right Click");
        }
        //Middle Mouse Click
        if(Input.GetMouseButtonDown(2)) 
        {
            Debug.Log("Mouse 2 - Middle Mouse Click");
        }
    }
}
