using UnityEngine;

public class LevelClear : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < transform.position.y - 1)
        {
            Destroy(gameObject);
        }
    }
}
