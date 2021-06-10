//Made by Jacob Burke 6/7/21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; //This is required to use anything from DOTween

//Here is the link to DOTweens documentation
//http://dotween.demigiant.com/documentation.php
//And a helpful video going over DOTween
//https://www.youtube.com/watch?v=UX15L5xtLwg


public class DOTransform : MonoBehaviour
{
    //Private Variables
    //We use private variables for better practice, public variables are less safe and can be accessed by anything.
    //To make it so that we can still access these private variables from the editor, we must put SerializeField in front of it
    //https://docs.unity3d.com/ScriptReference/SerializeField.html

    [SerializeField] Transform cubeTransform;      //Used to access and change the transform component
    [SerializeField] float animDuration = 0.2f;    //How long the animation lasts, the duration of it. Is defaulted to 0.2f
    [SerializeField] Ease animEase = Ease.OutCirc; //The type of ease used for the transform, defaulted to OutCirc
    

    // Start is called before the first frame update
    void Start()
    {
        //DOMoveY is an external function that acts on the cube transform.
        //It takes two floats which are used for height and duration respectively
        //Set ease is needed to set the type of ease (or it defaults to linear)
        //Set loops takes a looptype, and will loop based on that parameter.
        cubeTransform.DOMoveY(3f, animDuration)
            .SetEase(animEase)
            .SetLoops(-1, LoopType.Yoyo);

        //We do the same thing above to the X scale and Y scale in the following bits.
        //This is done to give the ball the appearance of getting squished.
        cubeTransform.DOScaleY(1f, animDuration)
            .SetEase(animEase)
            .SetLoops(-1, LoopType.Yoyo);

        cubeTransform.DOScaleX(0.5f, animDuration)
            .SetEase(animEase)
            .SetLoops(-1, LoopType.Yoyo);

    }
}
