using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public WaveManager wm;
    public GameObject dropObject;
    public ParticleSystem deatheffect;
    public Reset gamesystem;
    private bool dead = false;
    // Start is called before the first frame update
    private void Awake()
    {
        wm = GameObject.Find("GameManager").GetComponent<WaveManager>();
        deatheffect = GetComponent<ParticleSystem>();
        gamesystem = GameObject.Find("GameManager").GetComponent<Reset>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "bullet(Clone)")
        {
            health = health - 1;
        }

        if (health <= 0 && dead == false)
        {
            dead = true;
            Die();
        }

    }
    public void Die()
    {
        Debug.Log("enemy death");
        wm.countUp();
        float drop = Random.Range(0, 6);
        if (drop == 1)
        {
            Instantiate(dropObject, transform.position, transform.rotation);
        }
        Debug.Log("enemydestroyed");
        Destroy(gameObject);
    }
}
