using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour

{
    public GameObject EnemyBall;

    public Vector3 center;
    public Vector3 size;

    public int spawnNumber;

    // Start is called before the first frame update
    void Start()
    {

        int i;
        for (i = 0; i < spawnNumber; i++)
        {
            spawnBody(EnemyBall);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnBody(GameObject EnemyBall)
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2));
        GameObject clone = Instantiate(EnemyBall, pos, Quaternion.Euler(0,0,0));
    }
}