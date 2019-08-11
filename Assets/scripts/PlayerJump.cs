using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce;
    public bool onGround;
    public Rigidbody rb;

    private void Awake()
    {
        rb = GameObject.Find("Player").GetComponent<Rigidbody>();
        onGround = true;
}

    void Update()
    {
        if (Input.GetButtonDown("Jump") && onGround == true)
        {
            rb.velocity = Vector3.up * jumpForce;
            onGround = false;
            Debug.Log("jumping boii");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Grounded");
        onGround = true;
    }
    
}
