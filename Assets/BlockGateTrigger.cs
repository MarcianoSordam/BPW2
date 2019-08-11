using UnityEngine;
using System.Collections;

public class BlockGateTrigger : MonoBehaviour
{
    public GateTrigger trigger;
    public int Timer = 5;
    public GameObject greenbox;
    public GameObject redBox;
    public bool active = false;

    //public Material OriginalMat;

    private void Awake()
    {
        //Renderer.Material
        //OriginalMat = GetComponent<Material>();
        //Material newMat = new Material(OriginalMat);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "bullet(Clone)" & active == false)
        {
            active = true;
            Debug.Log("hit");
            trigger.CountUp();
            StartCoroutine(OnOf());
        }

        
    }

    IEnumerator OnOf()
    {
        greenbox.SetActive(true);
        redBox.SetActive(false);
        yield return new WaitForSeconds(5);
        redBox.SetActive(true);
        greenbox.SetActive(false);
        trigger.countdown();
        active = false;
    }
}
