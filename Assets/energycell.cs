using UnityEngine;

public class energycell : MonoBehaviour
{
    public playerBlock shield;
    public float count;
    private void Awake()
    {
        shield = GameObject.Find("PLayerModel").GetComponent<playerBlock>();
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
