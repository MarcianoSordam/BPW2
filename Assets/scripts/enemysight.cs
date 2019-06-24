using UnityEngine;

public class enemysight : MonoBehaviour
{
    public playerStealth player;
    private void OnTriggerEnter(Collider other)
    {
        player.PlayerSeen();
    }

}
