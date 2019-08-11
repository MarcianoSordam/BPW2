using UnityEngine;

public class energycell : MonoBehaviour
{
    public playerBlock shield;
    public float count;
    public float lifetime = 20f;

    private void Awake()
    {
        shield = GameObject.Find("PLayerModel").GetComponent<playerBlock>();
    }

    private void FixedUpdate()
    {
        lifetime -= 1 * Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        count = shield.shieldcount;
        if (other.gameObject.name == "Player" && count<3)
        {
            shield.shieldcount += 1;
            Debug.Log("shield up");
            Destroy(gameObject);
            shield.UIUpdate();
        }
    }
}
