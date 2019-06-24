using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public float health;
    public Slider healthbar;
    public Reset gamesystem;
    
    public void Dmg(float amount)
    {
        health -= amount;
        Debug.Log(health);
        if (health <= 0)
        {
            Debug.Log("gameover");
            gamesystem.GameOver();
        }
        healthbar.value = health / 30;
    }

    public void Heal(float amount)
    {
        health += amount;
        Debug.Log(health);
        healthbar.value = health / 30;
    }


}
