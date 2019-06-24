using System.Collections;
using UnityEngine;
using XInputDotNetPure;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireSpeed = 4;
    float fire = 1;
    public ParticleSystem muzzleFlash;
    public float triggerPoint = 1;

    bool playerIndexSet = false;
    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;

    private void Start()
    {
        //bulletPrefab = GameObject.Find("bullet");
    }
    // Update is called once per frame
    void Update()
    {
        if (state.Triggers.Right >= triggerPoint)
        {

            Shoot();

        }

        if (!playerIndexSet || !prevState.IsConnected)
        {
            for (int i = 0; i < 4; ++i)
            {
                PlayerIndex testPlayerIndex = (PlayerIndex)i;
                GamePadState testState = GamePad.GetState(testPlayerIndex);
                if (testState.IsConnected)
                {
                    Debug.Log(string.Format("GamePad found {0}", testPlayerIndex));
                    playerIndex = testPlayerIndex;
                    playerIndexSet = true;
                }
            }
        }

        prevState = state;
        state = GamePad.GetState(playerIndex);

        /*
        // Detect if a button was pressed this frame
        if (prevState.Buttons.A == ButtonState.Released && state.Buttons.A == ButtonState.Pressed)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
        }
        // Detect if a button was released this frame
        if (prevState.Buttons.A == ButtonState.Pressed && state.Buttons.A == ButtonState.Released)
        {
            GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }

        // Make the current object turn
        transform.localRotation *= Quaternion.Euler(0.0f, state.ThumbSticks.Left.X * 25.0f * Time.deltaTime, 0.0f);
        */

    }

    void Shoot()
    {
        
        if (fire >= 1)
        {
            StartCoroutine(ShootRumle());
            GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            muzzleFlash.Play();
            Destroy(Bullet, 5f);
            fire = 0;
        }
        fire += fireSpeed * Time.deltaTime;
        

    }

    void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger)
    {

    }

    IEnumerator ShootRumle()
    {
        GamePad.SetVibration(playerIndex, 1, 1);
        yield return new WaitForSeconds(0.1f);
        GamePad.SetVibration(playerIndex, 0, 0);
    }
}



