using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOoutBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30;
    private float lowerBound = -15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
