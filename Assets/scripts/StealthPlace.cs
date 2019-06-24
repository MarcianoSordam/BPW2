using UnityEngine;

public class StealthPlace : MonoBehaviour
{
    public playerStealth player;
    public Animator animator;


    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<playerStealth>();
        animator = GameObject.Find("StealthEffect").GetComponent<Animator>();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
        player.stealth = true;
        animator.SetBool("Visable", true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
        player.stealth = false;
        animator.SetBool("Visable", false);
        }
    }
}
