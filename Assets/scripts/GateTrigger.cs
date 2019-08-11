using UnityEngine;
using System.Collections;

public class GateTrigger : MonoBehaviour
{
    public GameObject gate;
    public float MaxBlock;
    public float BlockCount;
    public float speed;
    public float upMovement;
    public float step = 10;
    private Vector3 positionreset;

    private void Awake()
    {
        positionreset = gate.transform.position;
    }

    public void CountUp()
    {
        BlockCount += 1;

        if  (BlockCount == MaxBlock)
        {
            StartCoroutine(GateUp());
        }
    }

    public void countdown()
    {
        BlockCount -= 1;
        StopCoroutine(GateUp());
        gate.transform.position = positionreset;

    }

    IEnumerator GateUp()
    {
        Debug.Log("start Gate Up");
        for (int i = 0; i < step; i++)
        {
            gate.transform.position = new Vector3(gate.transform.position.x, gate.transform.position.y + (upMovement/step), gate.transform.position.z);
            yield return new WaitForSeconds(speed);
        }

    }


}
