﻿using UnityEngine;

public class Apple : MonoBehaviour
{

    public float bottomY = -20f;

    void Start()
    {
    }

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            // Call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();
        }
    }
}
