using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    public float xPos;
    public float yPos;
    public float zPos;

    private void Start()
    {
        player = GameObject.Find("Player");
    }
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x + xPos, yPos, player.transform.position.z + zPos);
    }
}
