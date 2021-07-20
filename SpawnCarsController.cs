using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarsController : MonoBehaviour
{
    public List<Transform> SpawnPosition = new List<Transform>();
    public float distanceSpawnPosition;
    public GameObject[] cars;

    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    IEnumerator SpawnCars()
    {
        while (true)
        {
            Instantiate (cars[Random.Range(0, cars.Length -1)], 
                SpawnPosition[Random.Range(0, 4)].position,
                 Quaternion.Euler(new Vector3(90, 180, 0)));
            yield return new WaitForSeconds(0.5f);
        }

        

    }

}

