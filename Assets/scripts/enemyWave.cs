using UnityEngine;
using System.Collections;

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
    public SoundTrackManager soundtrack;
    public Vector3[] spawnPoints;
    public int[] Wave1_Point;
    public int[] Wave2_Point;
    public int[] Wave3_Point;
    public GameObject DisableAfterWin;
    public int Level = 0;
    

    private void Awake()
    {
        soundtrack = GameObject.Find("Soundtrack").GetComponent<SoundTrackManager>();
        wm = GameObject.Find("GameManager").GetComponent<WaveManager>();
        wave = 1;
        Debug.Log("waveManager Started");
       
    }

    private void Start()
    {
        //turn up volume
        soundtrack.VolumeUp(Level);
    }

    private void Update()
    {
        
        if (wave == 1)
        {
            if (spawned == false)
            {
                Debug.Log("wave 1 started");
                SpawnWave(Wave1_Point[0], Wave1_Point[1], Wave1_Point[2], Wave1_Point[3]);
                spawned = true;
            }

            //wait until all enemys are dead
            if (wm.enemyDeath == 4)
            {
                Debug.Log("wave 1 Ended");
                wave = 2;
                wm.DoReset();
                spawned = false;
            }
        }

        else if (wave == 2)
        {
            if (spawned == false)
            {
                Debug.Log("wave 2 started");
                SpawnWave(Wave2_Point[0],Wave2_Point[1], Wave2_Point[2], Wave2_Point[3]);

                spawned = true;
            }

            //wait until all enemys are dead
            if (wm.enemyDeath == 4)
            {
                Debug.Log("wave 2 Ended");
                wave = 3;
                wm.DoReset();
                spawned = false;

            }
        }

        else if  (wave == 3)
        {
            if (spawned == false)
            {
                Debug.Log("wave 3 started");
                SpawnWave(Wave2_Point[0], Wave2_Point[1], Wave2_Point[2], Wave2_Point[3]);
                spawned = true;
            }

            //wait until all enemys are dead
            if (wm.enemyDeath == 4)
            {
                soundtrack.VolumeDown();
                Debug.Log("wave 3 ended");
                wave = 1;
                wm.DoReset();
                spawned = false;
                enabled = false;
                DisableAfterWin.SetActive(false);
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

