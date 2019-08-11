using UnityEngine;

public class rotationMatch : MonoBehaviour
{
    public GameObject player;
    //Rotation Bug fix
    void Update()
    {
        transform.rotation = player.transform.rotation;
    }


}
