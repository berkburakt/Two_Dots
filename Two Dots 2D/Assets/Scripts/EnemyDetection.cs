using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(transform.name == "GreenBall")
        {
            if(collision.transform.tag == "EnemyGreen")
            {
                Destroy(collision.gameObject);
            } else
            {

            }
        } else
        {
            if (collision.transform.tag == "EnemyPurple")
            {
                Destroy(collision.gameObject);
            }
            else
            {

            }
        }
    }
}
