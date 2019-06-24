using UnityEngine;

public class WaveStarter : MonoBehaviour
{
    public enemyWave wavespawner;
    public WaveManager wavemanager;
    private void Awake()
    {
        wavespawner = GetComponent<enemyWave>();
        wavemanager = GameObject.Find("GameManager").GetComponent<WaveManager>();

    }

    public void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.name == "Player")
        {
            wavespawner.enabled = true;
            wavemanager.DoReset();

        }
    }

}
