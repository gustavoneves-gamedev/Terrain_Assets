using UnityEngine;
using UnityEngine.InputSystem.XR;

public class BaseScript : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5.0f;
    public float rotateSpeed = 150.0f;


    public float rotationX;
    public float sensitivity = 5f;

    void Start()
    {
        // Pega automaticamente o componente anexado ao objeto
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
       

        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.SimpleMove(move * speed);



    }
}
