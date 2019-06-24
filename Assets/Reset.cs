using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject WinnerScreen;
    public float count;
    public float completekill;

    private void Update()
    {
        if (count == completekill)
        {
            Winner();
        }
    }
    public void CountUp()
    {
        count += 1;
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        StartCoroutine(Restart());
    }

    public void Winner()
    {
        WinnerScreen.SetActive(true);
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("homeBase");
        
    }

}
