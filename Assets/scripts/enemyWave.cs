using UnityEngine;

public class enemyWave : MonoBehaviour
{
    private float wave = 1;
    private bool spawned = false;
    private bool entered = false;
    private bool waveEnd = false;
    public GameObject enemyTurret;
    public GameObject enemyElete;
    public GameObject enemyRunner;
    public WaveManager wm;
    public Vector3[] spawnPoints;
        
    private void Awake()
    {
        wm = GameObject.Find("GameManager").GetComponent<WaveManager>();
        wave = 1;
        Debug.Log("waveManager Started");
    }
    private void Update()
    {
        //spawn 3 enemys
        if (wave == 1)
        {
            if (spawned == false)
            {
                Debug.Log("wave 1 started");
                //Instantiate(enemyTurret, SpawnPoint1, transform.rotation);
                //Instantiate(enemyTurret, SpawnPoint4, transform.rotation);
                //Instantiate(enemyRunner, SpawnPoint7, transform.rotation);
                SpawnWave(1, 3, 5);
                spawned = true;
            }

            //wait until all enemys are dead
            if (wm.enemyDeath == 3)
            {
                Debug.Log("wave 1 Ended");
                wave = 2;
                wm.DoReset();
                spawned = false;
            }
        }

        // spawn 5 enemys
        else if (wave == 2)
        {
            if (spawned == false)
            {
                Debug.Log("wave 2 started");
                //Instantiate(enemyTurret, SpawnPoint3, transform.rotation);
                //Instantiate(enemyTurret, SpawnPoint1, transform.rotation);
                //Instantiate(enemyTurret, SpawnPoint2, transform.rotation);
                //Instantiate(enemyRunner, SpawnPoint5, transform.rotation);
                //Instantiate(enemyRunner, SpawnPoint6, transform.rotation);
                SpawnWave(2, 6, 4, 7, 1);

                spawned = true;
            }

            //wait until all enemys are dead
            if (wm.enemyDeath == 5)
            {
                Debug.Log("wave 2 Ended");
                wave = 3;
                wm.DoReset();
                spawned = false;

            }
        }

        // spawn 7 enemys

        else if  (wave == 3)
        {
            if (spawned == false)
            {
                Debug.Log("wave 3 started");
                //Instantiate(enemyTurret, SpawnPoint4, transform.rotation);
                //Instantiate(enemyTurret, SpawnPoint3, transform.rotation);
                //Instantiate(enemyTurret, SpawnPoint5, transform.rotation);
                //Instantiate(enemyRunner, SpawnPoint6, transform.rotation);
                //Instantiate(enemyRunner, SpawnPoint2, transform.rotation);
                //Instantiate(enemyTurret, SpawnPoint7, transform.rotation);
                //Instantiate(enemyRunner, SpawnPoint1, transform.rotation);
                SpawnWave(1, 2, 3, 4, 5, 6, 7);
                spawned = true;
            }

            //wait until all enemys are dead
            if (wm.enemyDeath == 7)
            {
                Debug.Log("wave 3 ended");
                wave = 1;
                wm.DoReset();
                spawned = false;
                enabled = false;
            }
        }

    }

    public void SpawnWave(params int[] indices)
    {
        for (int j = 0; j < indices.Length; j++)
        {
            Instantiate(Choose(enemyElete, enemyTurret, enemyRunner), spawnPoints[indices[j] - 1], transform.rotation);
            
        }

    }


    public T Choose<T>(params T[] list)
    {
        return list[Random.Range(0, list.Length)];
    }

}
