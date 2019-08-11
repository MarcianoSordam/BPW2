using UnityEngine;
using System.Collections;

public class SoundTrackManager : MonoBehaviour
{
    public int level = 0;
    public Track1Mod track1;
    public Track2Mod track2;
    public Track3Mod track3;
    public AudioSource BattleTrack;
    public AudioSource EndSoundTrack;

    private void Awake()
    {
        track1 = GetComponent<Track1Mod>();
        track2 = GetComponent<Track2Mod>();
        track3 = GetComponent<Track3Mod>();
        BattleTrack = GameObject.Find("BattleTrack").GetComponent<AudioSource>();
    }

    

    public void VolumeUp(int levelNumber)
    {
        level = levelNumber;
        switch (level)
        {
            case 0:
                Debug.Log("no level set");
                break;
            case 1:
                track1.StartTrack();
                break;
            case 2:
                track1.StartTrack();
                track2.StartTrack();
                break;
            case 3:
                track1.StartTrack();
                track2.StartTrack();
                track3.StartTrack();
                break;
        }       
    }

    public void VolumeDown()
    {
        switch (level)
        {
            case 0:
                Debug.Log("no level set");
                break;
            case 1:
                track1.EndTrack();
                break;
            case 2:
                track1.EndTrack();
                track2.EndTrack();
                break;
            case 3:
                track1.EndTrack();
                track2.EndTrack();
                track3.EndTrack();
                break;

        }

    }
    public void EndSound()
    {

        StartCoroutine(EndSequence());
        EndSoundTrack.Play();
    }

    IEnumerator EndSequence()
    {
        Debug.Log("BattleTrack Ended");
        for (int i = 0; i <= 20; i++)
        {
            BattleTrack.volume -= 0.05f;

            yield return new WaitForSeconds(0.1f);
        }

        BattleTrack.volume = 0;

    }
}
