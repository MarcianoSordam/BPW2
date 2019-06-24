using UnityEngine;
using System.Collections;

public class enemyWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float shootTimer = 0;
    public float waitMin = 1;
    public float waitMax = 4;
    private float wait;
    public Animator animator;

    private void Awake()
    {
        
        wait = (Random.Range(waitMin, waitMax));
         

    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += 1 * Time.deltaTime;
        if (shootTimer >= wait)
        {
            StartCoroutine(Shoot());
            shootTimer = 0;
        }
    }

    IEnumerator Shoot()
    {
        animator.SetBool("Shooting", true);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Destroy(bullet, 5f);
        yield return new WaitForSeconds(1f);
        animator.SetBool("Shooting", false);
    }
}
