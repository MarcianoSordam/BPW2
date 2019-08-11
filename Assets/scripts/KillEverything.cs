using UnityEngine;

public class KillEverything : MonoBehaviour
{
    public WaveManager wm;
    private void Awake()
    {
        wm = GameObject.Find("GameManager").GetComponent<WaveManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        wm.countUp();

    }
}
