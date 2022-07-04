using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody2D squareRigidbody;
    private float horizontalInput;
    public float movementSpeed;

    private void Start()
    {
        squareRigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        CheckInput();
        ApplyMovement();
    }

    private void CheckInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void ApplyMovement()
    {
        squareRigidbody.velocity = new Vector2(movementSpeed * horizontalInput, 0);
    }
}
