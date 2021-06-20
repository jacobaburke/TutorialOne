//Made by Jacob Burke 6/20/21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    //Stores the rigidbody of the object and our target in usable variables
    Rigidbody2D playerRigidbody;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the rigidbody variable correctly.
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        //ALl necessary floats for the equation
        float displacement = target.transform.position.y - transform.position.y;
        float finalVelocity = 0f;
        float initialVelocity;
        float acceleration = Physics2D.gravity.y;

        //Calculates initial velocity
        initialVelocity = Mathf.Sqrt(finalVelocity - 2f * acceleration * displacement);

        //Adds force, set the force mode to impulse as we don't have anything over time
        playerRigidbody.AddForce(new Vector2(0f, initialVelocity), ForceMode2D.Impulse);
    }
}