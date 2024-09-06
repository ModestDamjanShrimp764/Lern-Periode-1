 using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;    // Bewegungsgeschwindigkeit
    public float jumpForce = 10f;   // Sprungkraft

    private Rigidbody2D rb;         // Referenz auf das Rigidbody2D des Spielers
    private bool isGrounded;        // Gibt an, ob der Spieler den Boden berührt

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Bewegung nach links und rechts
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Sprung-Mechanik
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    // Kollisionserkennung beim Betreten
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Kollisionserkennung beim Verlassen
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
