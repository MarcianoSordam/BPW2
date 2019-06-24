using System.Collections;
using UnityEngine;

public class CameraMovetowards : MonoBehaviour
{

    public PlayerMovement playermovement;
    public float height;
    
    void Awake()
    {
        height = 20f;
    }
    public void Move(float duration, float xPos, float zPos)
    {
        StartCoroutine(ChangePosition(duration, xPos, zPos));
        Debug.Log("Move Has Started");
    }

    public IEnumerator ChangePosition(float duration, float xPos, float zPos)
    {

        //GameObject.Find("Player").GetComponent<playerMovement>().enabled = false;
        Debug.Log("movement disabled");
        float t = 0;
        float step = 1f / duration;
        while (t < 1)
        {
            t += Time.deltaTime * step; 
            yield return null;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(xPos, height, zPos),step);

        }
        transform.position = new Vector3(xPos, height, zPos);
        //GameObject.Find("Player").GetComponent<playerMovement>().enabled = true;
        Debug.Log("movement enabled");

    }
}
