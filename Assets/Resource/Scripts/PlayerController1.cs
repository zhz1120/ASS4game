using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float checkRadius = 0.5f;
    public Color Pcolor = Color.white;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isWhite = true;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractWithObject();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ToggleColor();
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);
    }
    private void setNewSpeed(float newSpeed){
        moveSpeed = newSpeed;
    }

    private void InteractWithObject()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, 2f);

        if (hit.collider != null && hit.collider.CompareTag("Interactable"))
        {
            Debug.Log("Interacting with " + hit.collider.name);
            // Implement any additional interaction logic here
        }
    }

    private void ToggleColor()
    {
        if (isWhite)
        {
            spriteRenderer.color = Color.black;
            Pcolor = Color.black;
            isWhite = false;
        }
        else
        {
            spriteRenderer.color = Color.white;
            Pcolor = Color.white;
            isWhite = true;
        }
    }
}
