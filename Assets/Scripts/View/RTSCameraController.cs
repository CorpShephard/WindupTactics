using UnityEngine;

public class RTSCameraController : MonoBehaviour {

    public float panSpeed = 10f;
    public float panBorderThickness = 10f;
	
	// Update is called once per frame
	void Update () {

        Vector3 futurePos = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height-panBorderThickness) // Check for cardinal movement keys
        {
            futurePos.y += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            futurePos.y -= panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            futurePos.x -= panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            futurePos.x += panSpeed * Time.deltaTime;
        }

        transform.position = futurePos;
    }
}
