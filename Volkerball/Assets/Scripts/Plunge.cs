using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunge : MonoBehaviour
{
    public float speed = 10.0f;
    Vector2 current;
    public GameObject plunger;
    Vector2 starting;
    void start()
    {
        plunger = gameObject.GetComponent<GameObject>();
        current = plunger.transform.position;
        starting = current;
    }
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        
    }
}
