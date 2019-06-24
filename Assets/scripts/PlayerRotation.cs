using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float speed = 1f;
    public Transform cam;
    Transform target;

    private void Awake()
    {
        cam = FindObjectOfType<Camera>().transform;
    }

    void FixedUpdate()
    {
        Vector3 forward = Vector3.Scale(new Vector3(1, 0, 1), cam.forward);
        Vector3 right = Vector3.Scale(new Vector3(1, 0, 1), cam.right);
        float step = speed * Time.deltaTime * 2;

        Quaternion correction = Quaternion.Euler(0, cam.eulerAngles.y, 0);

        Vector3 targetDir = correction * Vector3.right * Input.GetAxis("Horizontal_2") + correction * Vector3.forward * Input.GetAxis("Vertical_2");
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f).normalized;
        if (newDir.sqrMagnitude > 0.0f)
        {
            transform.rotation = Quaternion.LookRotation(newDir, Vector3.up);
            
        }

    }



}