using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject JumpScreen;

    public void GameOver()
    {
        JumpScreen.SetActive(false);
        GameOverScreen.SetActive(true);

        StartCoroutine(Restart());
    }

    

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("homeBase");
        
    }

}
