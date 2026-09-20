using UnityEngine;

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
        // Rotaciona o personagem no eixo Y (Horizontal / A e D)
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Move para frente e para trás baseado no input (Vertical / W e S)
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");

        // Executa o movimento simples (gravidade inclusa automaticamente)
        controller.SimpleMove(forward * curSpeed);
    }
}
