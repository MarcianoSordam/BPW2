using UnityEngine;

public class ActivateSoundtrack : MonoBehaviour
{
    public AudioSource track1, track2, track3, track4;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "bullet(Clone)")
        {
            Debug.Log("soundtrack start");
            track1.Play();
            track2.Play();
            track3.Play();
            track4.Play();
        }

        enabled = false;
    }
}
