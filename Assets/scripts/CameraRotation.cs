using System.Collections;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform target;
    public float rotspeed = 1;
    public float duration = 1;
    public float camRot;
    public float newRot;
    float step;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Ltrigger"))
        {
            camRot -= 90f;
            
        }

        if (Input.GetButtonDown("Rtrigger"))
        {

            camRot += 90f;
        }
        step = rotspeed * Time.deltaTime;
        transform.LookAt(target);
        newRot = Mathf.SmoothStep(newRot, camRot, step);
        target.rotation = Quaternion.Euler(0, newRot, 0);
        


    }

    /*
    IEnumerator lerping()
    {
        float t = 0;
        float step = 1f / duration;
        while (t < 1)
        {
            t += Time.deltaTime * step;
            yield return null;
            camRot = Mathf.SmoothStep(target.rotation.y, camRot, step);
        }
        

    }
    */
    
}
