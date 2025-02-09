using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scroller : MonoBehaviour {
    public float speed = 4.0f;
    public float backgroundWidth = 2.65f;

    private float minX;
    private float maxX;
    private float cameraHalfWidth;

    void Start()
    {
        Camera cam = Camera.main;
        cameraHalfWidth = cam.orthographicSize * cam.aspect;

        float bgHalfWidth = backgroundWidth * cameraHalfWidth;
        minX = -bgHalfWidth + cameraHalfWidth;
        maxX = bgHalfWidth - cameraHalfWidth;
    }

    void Update()
    {
        float move = 0;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            move = speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            move = -speed * Time.deltaTime;
        }

        float newX = Mathf.Clamp(transform.position.x + move, minX, maxX);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
