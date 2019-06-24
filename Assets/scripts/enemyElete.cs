using UnityEngine.AI;
using UnityEngine;

public class enemyElete : MonoBehaviour
{
    public playerHealth player;
    public WaveManager wm;
    public float lookradius = 10f;
    bool combat = false;
    private float shootTimer = 0;
    public float waitMin = 1;
    public float waitMax = 4;
    private float wait;


    public Transform firePoint;
    public Transform firePoint2;
    public GameObject bulletPrefab;
    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player").transform;
        player = GameObject.Find("Player").GetComponent<playerHealth>();
        wm = GameObject.Find("GameManager").GetComponent<WaveManager>();
        wait = (Random.Range(waitMin, waitMax));
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookradius)
        {
            agent.SetDestination(target.position);
            combat = true;
        }
        else
        {
            combat = false;
        }

        if (combat == true)
        {
            shootTimer += 1 * Time.deltaTime;
            if (shootTimer >= wait)
            {
                Shoot();
                shootTimer = 0;
            }
        }

    }
    

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookradius);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
    }

}
