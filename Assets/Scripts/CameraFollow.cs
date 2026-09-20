using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //private Vector3 target;

    //[SerializeField] private Transform targetToFollow;
    //[SerializeField] private Vector3 positionOffset;

    public float cameraOffset;

    [SerializeField] private Transform player;
    [SerializeField] private float sensitivity = 2f;

    private float rotationX;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Player gira para esquerda/direita
        player.Rotate(Vector3.up * mouseX);

        // Câmera olha para cima/baixo
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -80f, 80f);

        transform.localRotation = Quaternion.Euler(rotationX - cameraOffset, 0f, 0f);
    }
}
