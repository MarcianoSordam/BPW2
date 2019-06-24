using UnityEngine;

public class MoveCameraBox : MonoBehaviour
{
    public GameObject Camera;
    public CameraMovetowards CamMove;
    public float xPos;
    public float zPos;
    public float duration;

    private void Start()
    {
        Camera = GameObject.Find("Camera");
        CamMove = GameObject.Find("Camera").GetComponent<CameraMovetowards>();
    }

    private void OnTriggerEnter(Collider other)
    {
        CamMove.Move(duration, xPos, zPos);
        Debug.Log("start move");
    }
}
