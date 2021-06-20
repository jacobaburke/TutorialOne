//Made by Jacob Burke 6/20/21s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    public float speed = 1.0f; //Speed of transitions
    public Color startColor;   //The color we are starting from
    public Color endColor;     //The color we are ending at
    float startTime;           //Time we are starting the lerp from


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Sets our time (looping from Sin) for the lerp
        float t = (Mathf.Sin(Time.time - startTime) * speed);

        //The lerp function itself
        //since we are in 2D we can access the color through the sprite renderer
        GetComponent<SpriteRenderer>().color = Color.Lerp(startColor, endColor, t);
    }
}
