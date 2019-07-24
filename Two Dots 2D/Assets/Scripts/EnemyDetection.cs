using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public GameObject cameraShake;

    public bool isCollided;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }

    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = cameraShake.transform.localPosition;

        float elapsedTime = 0.0f;

        while (elapsedTime < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            cameraShake.transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsedTime += Time.deltaTime;

            yield return null; //waits untill next frame
        }
        cameraShake.transform.localPosition = originalPos;
    }

    public IEnumerator DestroyObject(GameObject obj)
    {
        yield return new WaitForSeconds(2);
        Destroy(obj);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(transform.name == "GreenBall")
        {
            if(collision.transform.tag == "EnemyGreen")
            {
                StartCoroutine(Shake(0.1f, 0.1f));
                collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
                collision.gameObject.GetComponent<SphereCollider>().enabled = false;
                collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                StartCoroutine(DestroyObject(collision.gameObject));

            }
            else
            {

            }
        } else
        {
            if (collision.transform.tag == "EnemyPurple")
            {
                StartCoroutine(Shake(0.1f, 0.1f));
                collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
                collision.gameObject.GetComponent<SphereCollider>().enabled = false;
                collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
                StartCoroutine(DestroyObject(collision.gameObject));

            }
            else
            {

            }
        }


    }
}
