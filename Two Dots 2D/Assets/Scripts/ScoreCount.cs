using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyPurple")
        {
            score += 1;
            Debug.Log(score);
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
