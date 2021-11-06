using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Range(0.0f, 5.0f)] float playerSpeed = 1.0f;
    private CharacterController controller;

    private void Start() {
        controller = GetComponent<CharacterController>();
    }

    private void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = (transform.right * horizontal) + (transform.forward * vertical);
        controller.Move(moveDirection * playerSpeed * Time.deltaTime);
    }
}
