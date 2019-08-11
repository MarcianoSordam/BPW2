using System.Collections;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera cam;
    public bool wide = false;
    public float wideAngle = 35;
    public float tightAngle = 9;
    float camAngle;

    private void Awake()
    {
        cam = FindObjectOfType<Camera>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            if (wide == false)
            {
                wide = true;
                camAngle = wideAngle;
                StartCoroutine(lerping());
            }

            else if (wide == true)
            {
                wide = false;
                camAngle = tightAngle;
                StartCoroutine(lerping());
            }
        }
        
    }

    IEnumerator lerping()
    {
        float t = 0;
        float step = 10*Time.deltaTime;
        while (t < 5)
        {
            t += Time.deltaTime * 1;
            yield return null;
            cam.fieldOfView = Mathf.SmoothStep(cam.fieldOfView, camAngle, step);
        }
    }


 }
