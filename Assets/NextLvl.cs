using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLvl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("playtest");
        }
    }
}
