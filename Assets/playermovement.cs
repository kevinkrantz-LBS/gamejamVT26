using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("R�relseinst�llningar")]
    public float moveSpeed = 8f;
    public float jumpForce = 12f;
    private bool isFacingRight = true;

    [Header("Hopp & Double Jump")]
    private bool canDoubleJump;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool isGrounded;

    [Header("Crouch")]
    public float crouchSpeed = 4f;
    public Collider2D crouchDisableCollider; // Valfritt: St�ng av huvud-collidern vid crouch

    private Rigidbody2D rb;
    private float horizontal;
    private bool isCrouching;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        // Kolla om vi st�r p� marken
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        if (isGrounded)
        {
            canDoubleJump = true;
        }

        // Hopp-logik
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                Jump();
            }
            else if (canDoubleJump)
            {
                Jump();
                canDoubleJump = false;
            }
        }

        // Crouch-logik
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.C))
        {
            isCrouching = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.C))
        {
            isCrouching = false;
        }

        Flip();
    }

    void FixedUpdate()
    {
        float currentSpeed = isCrouching ? crouchSpeed : moveSpeed;
        rb.linearVelocity = new Vector2(horizontal * currentSpeed, rb.linearVelocity.y);

        // Om du har en extra collider f�r huvudet kan du st�nga av den h�r
        if (crouchDisableCollider != null)
        {
            crouchDisableCollider.enabled = !isCrouching;
        }
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
