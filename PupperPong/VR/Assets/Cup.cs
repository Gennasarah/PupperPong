using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    CupGame cg;
    // Start is called before the first frame update
    void Start()
    {
        cg = GameObject.FindGameObjectWithTag("Finish").GetComponent<CupGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("Score 1");
            Destroy(gameObject);
            Destroy(col.gameObject);
            if (cg != null)
            {
                cg.SpawnNewBall();
            }
        }
    }


}
