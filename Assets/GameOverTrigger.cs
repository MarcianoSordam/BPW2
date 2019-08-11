using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public Reset Gamesystem;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Gamesystem.GameOver();
        }
    }
}
