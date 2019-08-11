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
        Debug.Log("destroyer triggered");
        Destroy(other.gameObject);
        wm.countUp();

    }
}
