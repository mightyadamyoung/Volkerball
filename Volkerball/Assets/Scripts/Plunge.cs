using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunge : MonoBehaviour
{
    public GameObject plunger;
    public int n = 0;
    public Transform position;
    Vector2 start;
    Vector2 current;
    void Start()
    {
        plunger = gameObject.GetComponent<GameObject>();
        position = gameObject.transform;
        start = position.transform.position;
        current = start;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            for (int i = 46; i > n; i--)
            {
                current.y --;
            }
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            gameObject.transform.position = start;
        }
    }
}
