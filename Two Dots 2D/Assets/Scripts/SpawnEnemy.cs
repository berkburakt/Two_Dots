using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour

{
    public GameObject EnemyBall;
    public GameObject Player;

    public Vector3 center;

    public Vector3[] spawnLocations;

    public int spawnNumber;

    float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnRandomly());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnRandomly()
    {
        int i;
        for (i = 0; i < spawnNumber; i++)
        {
            spawnBody(EnemyBall);
            yield return new WaitForSecondsRealtime(1f);
        }
        
    }

    public void spawnBody(GameObject EnemyBall)
    {

        Vector3 pos = center + spawnLocations[Random.Range(0, 20)];
        GameObject clone = Instantiate(EnemyBall, pos, Quaternion.identity);
        clone.GetComponent<Rigidbody>().velocity = (Player.transform.position - clone.transform.position).normalized * speed;
        
    }
}