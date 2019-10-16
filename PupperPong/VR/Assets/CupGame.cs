using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupGame : MonoBehaviour
{
    public GameObject ballPrefab;

    public Transform ballSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnNewBall()
    {
        Instantiate(ballPrefab, ballSpawnPoint.position, Quaternion.identity);

    }
}
