using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public Rigidbody rb;

    public float forwardForce = 50f;
    public float sidewaysForce = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("d"))
            rb.AddForce(sidewaysForce, 0, 0, ForceMode.VelocityChange);

        else if (Input.GetKey("w"))
            rb.AddForce(0, 0, forwardForce);

        else if (Input.GetKey("a"))
            rb.AddForce(-sidewaysForce, 0, 0, ForceMode.VelocityChange);

        else if (Input.GetKey("s"))
            rb.AddForce(0, 0, -forwardForce);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
