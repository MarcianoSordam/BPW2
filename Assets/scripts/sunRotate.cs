using UnityEngine;

public class sunRotate : MonoBehaviour
{
    public GameObject sun;
    public Vector3 sunRot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            sun.transform.Rotate(sunRot, Space.World);
        }
    }
}
