using UnityEngine;
using System.Collections;

public class Track2Mod : MonoBehaviour
{
    public AudioSource Track2;
    private void Awake()
    {
        Track2 = GameObject.Find("track2").GetComponent<AudioSource>();
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
                Track2.volume += 0.05f;

                yield return new WaitForSeconds(0.1f);
            }

            Track2.volume = 1;

        }
    }

    IEnumerator VolumeDown()
    {
        Debug.Log("BattleTrack Ended");
        for (int i = 0; i <= 20; i++)
        {
            Track2.volume -= 0.05f;

            yield return new WaitForSeconds(0.1f);
        }

        Track2.volume = 0;

    }
}
