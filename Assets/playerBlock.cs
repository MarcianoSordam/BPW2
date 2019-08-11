using System.Collections;
using UnityEngine;
using XInputDotNetPure;

public class playerBlock : MonoBehaviour
{
    //Player block is nu een rapid fire PowerUp.
    public float shieldcount;
    public GameObject shield;
    bool cooldown = false;
    public GameObject shield1;
    public GameObject shield2;
    public GameObject shield3;
    public Weapon weapon;

    private void Awake()
    {
        shieldcount = 3;
        weapon = GetComponent<Weapon>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Block") && cooldown == false && shieldcount >= 1)
        {
            cooldown = true;
            StartCoroutine(Shield());
            shieldcount -= 1;
            UIUpdate();
        }
        
    }

    public void UIUpdate()
    {
        if (shieldcount == 3)
        {
            shield1.SetActive(true);
            shield2.SetActive(true);
            shield3.SetActive(true);
        }
        if (shieldcount == 2)
        {
            shield1.SetActive(true);
            shield2.SetActive(true);
            shield3.SetActive(false);
        }
        if (shieldcount == 1)
        {
            shield1.SetActive(true);
            shield2.SetActive(false);
            shield3.SetActive(false);
        }
        if (shieldcount == 0)
        {
            shield1.SetActive(false);
            shield2.SetActive(false);
            shield3.SetActive(false);
        }
    }

    IEnumerator Shield()
    {
        weapon.SpeedUp();
        yield return new WaitForSeconds(2f);
        weapon.SpeedDown();
        yield return new WaitForSeconds(2f);
        cooldown = false;
    }
}
