using UnityEngine;

public class StartEndSound : MonoBehaviour
{
    public SoundTrackManager soundtrack;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            soundtrack.EndSound();
        }
    }
}
