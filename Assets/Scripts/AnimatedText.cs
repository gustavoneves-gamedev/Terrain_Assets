using UnityEngine;

public class AnimatedText : MonoBehaviour
{
    public float speed = 0.3f;
    public float size = 0.5f;
    float currentSize = 0;
    public float v = 0.1f;

    void Start()
    {
        currentSize = size;
    }    
    void Update()
    {
        currentSize += speed * Time.deltaTime;

        if (currentSize >= size + v)
        {
            speed = (speed * -1);
        }

        if (currentSize <= size - v)
        {
            speed = (speed * -1);
        }
        transform.localScale = new Vector3(currentSize, currentSize, currentSize);
    }
}