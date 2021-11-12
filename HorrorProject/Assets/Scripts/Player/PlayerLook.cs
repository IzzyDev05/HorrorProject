using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 100f;

    private GameObject cam;
    private float xRotation = 0.0f;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;

        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Look left and right
        transform.Rotate(Vector3.up * mouseX);

        // Look up and down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -74.0f, 74.0f);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
    }
}