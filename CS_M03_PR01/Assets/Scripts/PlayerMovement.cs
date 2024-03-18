using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    public float jumpVelocity = 5f;
    public float distanceToGround = 0.1f;

    private GameManager gameManager;
    private bool doJump = false;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            doJump = true;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -2f)
        {
            gameManager.EndGame();
        }

        if (doJump)
        {
            rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
            doJump = false;
        }
    }
    bool isGrounded()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.55f))
        {
            if (hit.collider.name == "Ground")
            {
                //Debug.Log(hit.collider.name);
                return true;
            }
            return false;
        }
        else
        {
            return false;
        }
    }
}
