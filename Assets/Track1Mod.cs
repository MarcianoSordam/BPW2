using UnityEngine;
using System.Collections;

public class Track1Mod : MonoBehaviour
{
    public AudioSource Track1;

    private void Awake()
    {
        Track1 = GameObject.Find("track1").GetComponent<AudioSource>();
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
                Track1.volume += 0.05f;

                yield return new WaitForSeconds(0.1f);
            }

            Track1.volume = 1;

        }
    }

    IEnumerator VolumeDown()
    {
        Debug.Log("BattleTrack Ended");
        for (int i = 0; i <= 20; i++)
        {
            Track1.volume -= 0.05f;

            yield return new WaitForSeconds(0.1f);
        }

        Track1.volume = 0;

    }
}
