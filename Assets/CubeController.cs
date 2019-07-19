using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -0.2f;

    private float deadLine = -10;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(this.speed, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "CubePrefab(Clone)" || collision.gameObject.name == "ground")
        {
            GetComponent<AudioSource>().Play();
        }
    }

}
