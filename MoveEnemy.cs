using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 1.5f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

            Destroy(gameObject, 5f);

    }
}
