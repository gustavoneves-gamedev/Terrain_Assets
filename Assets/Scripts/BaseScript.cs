using UnityEngine;
using UnityEngine.InputSystem.XR;

public class BaseScript : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5.0f;
    public float rotateSpeed = 150.0f;

    void Start()
    {
        // Pega automaticamente o componente anexado ao objeto
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {        
        //float rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        //transform.Rotate(0, rotation, 0);
        
        //Vector3 forward = transform.TransformDirection(Vector3.forward);
        //float realSpeed = speed * Input.GetAxis("Vertical");

        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(x, 0, z);

        controller.SimpleMove(move * speed);
        //controller.SimpleMove(forward * realSpeed);
    }
}
