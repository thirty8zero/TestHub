using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour 
{
    public GameObject explosion = null;

    void Update()
    {
        if (transform.position.y < -5)
            GameObject.Destroy(gameObject);
    }

    void OnCollisionEnter()
    {
        GameObject.Instantiate(explosion, transform.position, Quaternion.identity);
        GameObject.Destroy(gameObject);
    }
}
