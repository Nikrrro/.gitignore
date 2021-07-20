using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;
    float maxDistanceLeft = -2f;
    float maxDistanceRight = 3.1f;
    float maxDistanceUp;
    float maxDistanceDown;
    public GameObject player;
    public Transform camera;

    void Update()
    {
        camera = Camera.main.transform;


        maxDistanceUp = camera.position.y - 5f;
        maxDistanceDown = camera.position.y + 5f;

        float x = Mathf.Clamp(transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime, maxDistanceLeft, maxDistanceRight);
        float y = Mathf.Clamp(transform.position.y + Input.GetAxis("Vertical") * speed * Time.deltaTime, maxDistanceUp, maxDistanceDown);
        transform.position = new Vector2(x, y);
     
    }
}
