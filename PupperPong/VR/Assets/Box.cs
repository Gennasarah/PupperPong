using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    Renderer renderer; 


    // Start is called before the first frame update
    void Start()
    {
        renderer =  GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGrab ()
    {
        renderer.material.color = Color.red;
    }

    public void OnDrop ()
    {
        renderer.material.color = Color.green;
    }
}
