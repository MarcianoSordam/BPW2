using System.Collections;
using UnityEngine;

public class StartEndSequence : MonoBehaviour
{
    public GameObject EndScreen;
    public GameObject JumpScreen;
    public GameObject jumpBlock;
    public GameObject EndWall;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine(EndSequence());
        }
    }



    IEnumerator EndSequence()
    {
        EndScreen.SetActive(true);
        yield return new WaitForSeconds(21);
        EndScreen.SetActive(false);
        JumpScreen.SetActive(true);
        jumpBlock.SetActive(true);
        EndWall.SetActive(false);
    }
}
