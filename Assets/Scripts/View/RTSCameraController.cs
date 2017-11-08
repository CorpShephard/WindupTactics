using UnityEngine;

public class RTSCameraController : MonoBehaviour {

    public float panSpeed = 10f;
    public float panBorderThickness = 10f;
    public Vector2 panLimit;
    public float cameraSize;
    public float zoomSpeed = 1f;

    private Camera camera;


    //public float zoomSpeed = 20f; Zoom in and out

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

        camera = (Camera)this.GetComponent("Camera");
        float zoom = Input.GetAxis("Mouse ScrollWheel");
        camera.orthographicSize += zoom * zoomSpeed * 100f * Time.deltaTime;






        futurePos.x = Mathf.Clamp(futurePos.x, -panLimit.x, panLimit.x); // Clamp the raw position value based on editor defined limits.
        futurePos.y = Mathf.Clamp(futurePos.y, -panLimit.y, panLimit.y);

        transform.position = futurePos;
    }
}
