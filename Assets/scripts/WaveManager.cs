using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public float enemyDeath;

    // Update is called once per frame
    public void countUp()
    {
        enemyDeath += 1;
        Debug.Log(enemyDeath);
    }

    public void DoReset()
    {
        enemyDeath = 0;
    }
}
