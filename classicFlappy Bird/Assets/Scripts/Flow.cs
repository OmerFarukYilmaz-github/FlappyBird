using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour
{

    public float movementSpeed;

   private void Start()
    {
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
    }
}
