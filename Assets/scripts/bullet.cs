using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour
{
    private playerHealth player;
    public float speed = 20f;
    public GameObject impact;
    // Update is called once per frame
    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<playerHealth>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.Dmg(1);
        }

        StartCoroutine(destroy());
       
        
    }

    IEnumerator destroy()
    {
        //play animation
        yield return new WaitForEndOfFrame();
        GameObject effect = Instantiate(impact, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(effect, 2f);
    }


}
