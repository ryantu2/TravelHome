﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float positionSpeed = 10f;
    public float rotationSpeed = 10f;

    // Update is called once per frame
    void LateUpdate()
    {
        // Gets position and rotation
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        // Lerps / Slerps position and rotation
        position = Vector3.Lerp(position, target.position, positionSpeed * Time.deltaTime);
        rotation = Quaternion.Slerp(rotation, target.rotation, rotationSpeed * Time.deltaTime);

        // Applies the filtered position and rotation
        transform.position = position;
        transform.rotation = rotation;
    }
}

