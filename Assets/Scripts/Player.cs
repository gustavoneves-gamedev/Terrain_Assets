using UnityEngine;


[RequireComponent (typeof(CharacterController))]
public class Player : MonoBehaviour
{
    CharacterController cc;
    public float speed = 8.0f;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical");
        cc.SimpleMove(transform.forward * speed * v);
    }

    void LateUpdate()
    {
        Vector3 camDir = Camera.main.transform.forward;
        camDir.y = 0;
        transform.rotation = Quaternion.LookRotation(camDir);
    }
}
