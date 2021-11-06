using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] float lookSensitivity = 300f;

    private GameObject cam;
    private float xRotation = 0.0f;

    private void Start() {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void Update() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // Look up and down
        float mouseY = Input.GetAxis("Mouse Y") * lookSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -74.0f, 74.0f);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);

        // Look left and right
        float mouseX = Input.GetAxis("Mouse X") * lookSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);
    }
}
