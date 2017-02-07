using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlipScriptR : MonoBehaviour
{
    WheelJoint2D wheelJoints;
    JointMotor2D jointMotor;
    public Transform start;
    Vector2 begin;

    void Start()
    {
        wheelJoints = gameObject.GetComponent<WheelJoint2D>();
        start = gameObject.transform;
        begin = start.position;
        jointMotor = wheelJoints.motor;
        jointMotor.motorSpeed = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            jointMotor.motorSpeed = -100000;
        }
        else
        {
            gameObject.transform.position = begin;
            jointMotor.motorSpeed = 0;
        }
        wheelJoints.motor = jointMotor;
    }
}
