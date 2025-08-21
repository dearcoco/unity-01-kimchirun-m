using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Settings")]
    public float jumpForce;
    private bool isGrounded = true;
    [Header("References")]
    public Rigidbody2D rb;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            isGrounded = false;
            animator.SetInteger("state", 1); 
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Platform") {
            // if (!isGrounded) {
            //     animator.SetInteger("State", 2); // Reset to idle state
            // }
            animator.SetInteger("state", 2);
            isGrounded = true;
        }
    }
}
