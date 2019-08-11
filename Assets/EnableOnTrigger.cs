using UnityEngine;

public class EnableOnTrigger : MonoBehaviour
{
    public GameObject enableThis;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            enableThis.SetActive(true);
        }
    }
}
