using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 movement;
    private Rigidbody rb;
    private Transform cam;
    private bool dodgeCheck = false;
    public float dodgeDuration;
    float speedReset;
    float dodgeBoost;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cam = FindObjectOfType<Camera>().transform;
        speedReset = speed;
        dodgeBoost = speed * 3;
    }
    void FixedUpdate()
    {
        Vector3 forward = Vector3.Scale(new Vector3(1, 0, 1), cam.forward);
        Vector3 right = Vector3.Scale(new Vector3(1, 0, 1), cam.right);
        movement = (forward.normalized * Input.GetAxis("Vertical") + right.normalized * Input.GetAxis("Horizontal"));
        movement = Vector3.ClampMagnitude(movement * speed, speed);
        //transform.Translate(movement, Space.World);
        rb.MovePosition(transform.position + movement * Time.deltaTime);



        if (Input.GetButtonDown("Dodge") && dodgeCheck == false)
        {
            StartCoroutine (dodge());
        }
        
    }

    IEnumerator dodge()
    {
        dodgeCheck = true;
        float t = 0;
        while (t < dodgeDuration)
        {
            speed = dodgeBoost;
            t += Time.deltaTime * 1;
            yield return null;

        }
        speed = speedReset;
        dodgeCheck = false;
    }


}

