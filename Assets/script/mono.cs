using UnityEngine;

public class mono : MonoBehaviour
{
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal"); // A/D and Left/Right Arrow keys

        // Move the object left or right
        transform.Translate(Vector2.right * input * speed * Time.deltaTime);
    }
}
