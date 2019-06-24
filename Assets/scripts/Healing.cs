using UnityEngine;

public class Healing : MonoBehaviour
{
    public playerHealth player;
    public float amount;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<playerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name== "Player")
        {
            player.Heal(amount);
        }
    }
}
