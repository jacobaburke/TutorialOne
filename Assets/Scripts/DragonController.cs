//Made by Jacob Burke 6/8/21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

//Helpful Video Tutorials:
//Simple Animation in Unity: https://www.youtube.com/watch?v=Gf8LOFNnils

public class DragonController : MonoBehaviour
{
    //Access the animator of the object, keeping it private for only use in here
    private Animator animator;

    [SerializeField] Transform playerTransform; //Used to access and change the transform component
    [SerializeField] float speed;               //Speed of the movement

    //We need the awake class so we can access and set private variables
    private void Awake()
    {
        //Sets the animator using get component
        animator = GetComponent<Animator>();

        //The speed needs to be very small, we do this so we can use more reasonable numbers in the editor
        speed *= 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        //We use get button down so we can use the input manager unity offers
        //See https://docs.unity3d.com/Manual/class-InputManager.html
        //Sets the bool for the animation transition (ID must be exact).
        //Make sure to set the Has Exit Time to false in this situation for the transitions.
        //See https://docs.unity3d.com/Manual/class-Transition.html
        if (Input.GetButton("MoveRight") || Input.GetButton("MoveLeft"))
        {
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
        }

        //Basic movement using DOMove.
        //We also flip the player so that the animation looks normal.
        if (Input.GetButton("MoveRight"))
        {
            playerTransform.rotation = Quaternion.Euler(0, 0, 0);
            playerTransform.DOMoveX(playerTransform.position.x + speed, Time.deltaTime);
        }
        else if (Input.GetButton("MoveLeft"))
        {
            playerTransform.rotation = Quaternion.Euler(0, 180, 0);
            playerTransform.DOMoveX(playerTransform.position.x - speed, Time.deltaTime);
        }

    }
}
