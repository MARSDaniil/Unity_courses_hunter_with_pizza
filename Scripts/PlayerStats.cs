using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int score = 0;
    public static int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void ShowScore()
    {
        Debug.LogFormat("Lives: {0}  Animals fed: {1}", score, lives);
    }
}
