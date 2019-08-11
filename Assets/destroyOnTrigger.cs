using UnityEngine;

public class destroyOnTrigger : MonoBehaviour
{
    public GameObject destroyThis;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
        destroyThis.SetActive(false);

        }
    }
}
