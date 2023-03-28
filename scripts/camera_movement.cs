using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class camera_movement : MonoBehaviour
{
    public Transform tf;
    public Transform ballTransform;
    public Vector3 distanceBetweenBallAndCam;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        distanceBetweenBallAndCam = tf.position - ballTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tf.position = ballTransform.position + distanceBetweenBallAndCam;
        yRotation = ballTransform.eulerAngles.y;
        tf.eulerAngles = new Vector3(tf.eulerAngles.x, yRotation, tf.eulerAngles.z);
    }
}