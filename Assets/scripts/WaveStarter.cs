using UnityEngine;

public class WaveStarter : MonoBehaviour
{
    public enemyWave wavespawner;
    public WaveManager wavemanager;
    bool started = false;
    private void Awake()
    {
        wavespawner = GetComponent<enemyWave>();
        wavemanager = GameObject.Find("GameManager").GetComponent<WaveManager>();

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player" && started == false)
        {
            started = true;
            wavespawner.enabled = true;
            wavemanager.DoReset();

        }
    }

}
