using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    private Rigidbody2D rig;
    private Animator anim;

    public bool isJumping;
    public bool doubleJump;

    bool isBlowing;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float movement = Input.GetAxisRaw("Horizontal");
        rig.linearVelocity = new Vector2(movement * Speed, rig.linearVelocity.y);

        if (movement > 0)
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        else if (movement < 0)
            transform.eulerAngles = new Vector3(0f, 180f, 0f);

        anim.SetBool("walk", movement != 0);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && !isBlowing)
        {
            if (!isJumping)
            {
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                doubleJump = true;
                anim.SetBool("jump", true);
            }
            else if (doubleJump)
            {
                rig.AddForce(new Vector2(0f, JumpForce * 1.5f), ForceMode2D.Impulse);
                doubleJump = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isJumping = false;
            anim.SetBool("jump", false);
        }
        if (collision.gameObject.tag == "Spikes")
        {
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "saw")
        {
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isJumping = true;
        }
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 10)
        {
            isBlowing = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 10)
        {
            isBlowing = false;
        }
    }
}
