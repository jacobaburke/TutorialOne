//Made by Jacob Burke 6/9/21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Helpful Video Tutorials:
//Looking at mouse: https://www.youtube.com/watch?v=n1Tb-qfBR_0
//Shooting in Unity: https://www.youtube.com/watch?v=wkKsl1Mfp5M

public class Shooting : MonoBehaviour
{
    //Defaults to private
    [SerializeField] Transform firePoint; //Where the bullets come from, helpful when the gun is in a different location
    [SerializeField] Transform bullet;    //The bullet prefab, we had to make this seperately in unity then set it
    [SerializeField] int offset;          //Offset for rotation in case it is centered wrong.

    // Update is called once per frame
    void Update()
    {
        //Here we create a vector between the mouse position (which is in the screen), and the transform (which is in the world)
        //We need the world to screen point so the value can be properly compared.
        Vector3 direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

        //Uses inverse tan to find the proper angle
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + offset;

        //Set the transform using the angle we created
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //We use get button down so we can use the input manager unity offers
        //See https://docs.unity3d.com/Manual/class-InputManager.html
        if (Input.GetButtonDown("Fire1"))
        {
            LaunchProjectile(transform.rotation);
        }
    }

    void LaunchProjectile(Quaternion rotation)
    {
        //Instatiates the prefab we created earlier. The bullet is already coded to take the params and launch itself.
        Instantiate(bullet, firePoint.position, rotation);
    }
}