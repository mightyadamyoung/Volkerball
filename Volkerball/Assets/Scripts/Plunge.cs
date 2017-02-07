using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunge : MonoBehaviour {
    const float maxDistance = 1f;
    const float pullSpeed = 0.5f;
    const float resetSpeed = 10f;
    private Rigidbody2D body;
    private SpringJoint2D spring;
    public float max = 2200;
    public Transform distance;
    public GameObject ball;
    Vector2 start;
    Vector2 ballStart;
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        distance = body.transform;
        start = distance.transform.position;
        ballStart = ball.transform.position;
    }
	void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector2 moveAmount = new Vector2(0f,-pullSpeed * Time.deltaTime);
            distance.transform.Translate(moveAmount);
            ball.transform.Translate(moveAmount);

        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (Mathf.Abs(transform.position.y) - Mathf.Abs(ball.transform.position.y) < 1f)
            {
                float distance = Mathf.Abs(body.transform.position.y - start.y);
            }
        }
    }
}
