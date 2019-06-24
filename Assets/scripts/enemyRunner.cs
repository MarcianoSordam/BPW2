using UnityEngine;
using UnityEngine.AI;

public class enemyRunner : MonoBehaviour
{
    public playerHealth player;
    public WaveManager wm;
    public float lookradius = 10f;
    public ParticleSystem deatheffect;

    Transform target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player").transform;
        player = GameObject.Find("Player").GetComponent<playerHealth>();
        wm = GameObject.Find("GameManager").GetComponent<WaveManager>();
        deatheffect = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookradius)
        {
            agent.SetDestination(target.position);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.Dmg(3);
            wm.countUp();
            deatheffect.Play();
            Destroy(gameObject);
           
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,lookradius);
    }
    
}
