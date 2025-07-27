using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;   // Movement speed

    void Update()
    {
        // Get input from WASD or Arrow keys
        float horizontal = Input.GetAxis("Horizontal");  // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");      // W/S or Up/Down

        // Create movement direction
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        // Move the player (in world space)
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

if (direction != Vector3.zero)
{
    transform.forward = direction; // Makes the character face the moving direction
}

    }
}
