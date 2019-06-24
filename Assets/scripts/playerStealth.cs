using UnityEngine;

public class playerStealth : MonoBehaviour
{
    public bool stealth = false;

    public void PlayerSeen()
    {
        if (stealth == false)
        {
            Debug.Log("GameOver");
        }
    }
}
