using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float force = 8f;
    [SerializeField] private int maxJumps = 5;
    private int countJumps;
    private bool isTouchingGround;

    [SerializeField] private Color colorFlyingUp;
    [SerializeField] private Color colorFlyingDown;
    [SerializeField] private Color colorStopMoving;
    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnMouseDown()
    {
        if (isTouchingGround)
        {
            Jump();
        }
    }


    private void OnCollisionStay2D(Collision2D other)
    {
        isTouchingGround = true;
    }


    private void OnCollisionExit2D(Collision2D other)
    {
        isTouchingGround = false;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isTouchingGround)
        {
            Jump();
        }


        //Красим шарик
        if (_rigidbody2D.velocity.y > 0)
        {
            spriteRenderer.color = colorFlyingUp;
        }
        else if (_rigidbody2D.velocity.y < 0)
        {
            spriteRenderer.color = colorFlyingDown;
        }
        else
        {
            spriteRenderer.color = colorStopMoving;
        }
    }


    private void Jump()
    {
        if (countJumps < maxJumps)
        {
            countJumps++;
            _rigidbody2D.AddForce(transform.up * force, ForceMode2D.Impulse);

            Debug.Log("countJumps: " + countJumps);
        }
    }


}
