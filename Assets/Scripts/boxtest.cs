using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxtest : MonoBehaviour {

    var highlightbox : GUIStyle;

    void OnGUI()
    {
        //top left point of rectangle
        Vector3 boxPosHiLeftWorld = new Vector3(0.5f, 12, 0);
        //bottom right point of rectangle
        Vector3 boxPosLowRightWorld = new Vector3(1.5f, 0, 0);

        Vector3 boxPosHiLeftCamera = Camera.main.WorldToScreenPoint(boxPosHiLeftWorld);
        Vector3 boxPosLowRightCamera = Camera.main.WorldToScreenPoint(boxPosLowRightWorld);

        float width = boxPosHiLeftCamera.x - boxPosLowRightCamera.x;
        float height = boxPosHiLeftCamera.y - boxPosLowRightCamera.y;


        GUI.Box(new Rect(boxPosHiLeftCamera.x, Screen.height - boxPosHiLeftCamera.y, width, height), "", highlightBox);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
