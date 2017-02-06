using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunge : MonoBehaviour {
    private Rigidbody2D body;
    public static float distanceTraveled;
    // Use this for initialization
    void Start ()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        transform.Translate(5f * Time.deltaTime, 0f, 0f);
        distanceTraveled = transform.localPosition.x;
       // if (Input.GetKeyDown(KeyCode.DownArrow) && this.canJump == true)
        //{
         //   Vector2 vec = new Vector2(12f, jump);
           // body.AddForce(vec * 10);
          //  spriteRenderer.sprite = jumps;
            //playerJump.Play();
            //canJump = false;
        //}
    }
}
