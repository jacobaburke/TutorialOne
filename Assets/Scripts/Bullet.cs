//Made by Jacob Burke 6/7/21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //This should be public so that the shooter object can access them
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //Multiply the velocity on start by our speed
        rb.velocity = transform.right * speed;

        //The gameobject will go on forever unless we destroy it, which is why we call the Destroy function once
        Destroy(gameObject, 2f);
    }
}
