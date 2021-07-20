using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGrounds : MonoBehaviour
{
    public List<Transform> grounds = new List<Transform>();
    public float speed = 1f;
    public int nextGroundIndex;
    public float nextHeightGroundChange;
    public float groundChangeDistance;
    public float groundDistance;
    public Transform camera;

    public void Start()
    {
        camera = Camera.main.transform;
        groundDistance = (grounds[0].position - grounds[1].position).magnitude;
        nextHeightGroundChange = camera.position.y + groundChangeDistance;
        groundChangeDistance = groundDistance;
    }
    void Update()
    {
        if (camera.position.y > nextHeightGroundChange)
        {
            nextHeightGroundChange = camera.position.y + groundChangeDistance;
            grounds[nextGroundIndex].position = new Vector2(grounds[nextGroundIndex].position.x, grounds[nextGroundIndex].position.y + groundDistance * 3);
            if (grounds.Count - 1 == nextGroundIndex)
            {
                nextGroundIndex = 0;
            }
            else
            {
                nextGroundIndex++;
            }
        }

    }


}
