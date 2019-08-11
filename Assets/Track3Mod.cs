using UnityEngine;
using System.Collections;

public class Track3Mod : MonoBehaviour
{
    public AudioSource Track3;

    private void Awake()
    {
        Track3 = GameObject.Find("track3").GetComponent<AudioSource>();
    }

    public void StartTrack()
    {
        StartCoroutine(VolumeUp());
    }

    public void EndTrack()
    {
        StartCoroutine(VolumeDown());
    }

    IEnumerator VolumeUp()
    {
        {
            Debug.Log("BattleTrack Started");
            for (int i = 0; i <= 20; i++)
            {
                Track3.volume += 0.05f;
                yield return new WaitForSeconds(0.1f);
            }

            Track3.volume = 1;
        }
    }

    IEnumerator VolumeDown()
    {
        Debug.Log("BattleTrack Ended");
        for (int i = 0; i <= 20; i++)
        {
            Track3.volume -= 0.05f;
            yield return new WaitForSeconds(0.1f);
        }

        Track3.volume = 0;
    }
}
