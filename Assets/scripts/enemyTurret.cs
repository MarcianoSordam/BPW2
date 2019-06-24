
using UnityEngine;

public class enemyTurret : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    private void Awake()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
