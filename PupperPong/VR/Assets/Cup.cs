using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour //Checks if a ball has landed in the cup and then increases the score
{
    CupGame cg;
    ScoreManager sm;
    // Start is called before the first frame update
    void Start()
    {
        cg = GameObject.FindGameObjectWithTag("Finish").GetComponent<CupGame>();
        sm = GameObject.FindGameObjectWithTag("Finish").GetComponent<ScoreManager>();
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
                sm.IncrementScore();
            }
        }
    }

}
