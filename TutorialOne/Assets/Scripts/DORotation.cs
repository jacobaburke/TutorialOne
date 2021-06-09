//Made by Jacob Burke 6/7/21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; //Required for using any of the tweening functions

//Here is the link to DOTweens documentation
//http://dotween.demigiant.com/documentation.php
//And a helpful video going over DOTween
//https://www.youtube.com/watch?v=UX15L5xtLwg

public class DORotation : MonoBehaviour
{
    //Private Variables
    //We use private variables for better practice, public variables are less safe and can be accessed by anything.
    //To make it so that we can still access these private variables from the editor, we must put SerializeField in front of it
    //https://docs.unity3d.com/ScriptReference/SerializeField.html

    [SerializeField] Transform spriteTransform; //Used to access and change the transform component
    [SerializeField] float animDuration = 2f;   //How long the animation lasts, the duration of it. Is defaulted to 1f
    [SerializeField] Ease animEase;             //The type of ease used for the transform

    // Start is called before the first frame update
    void Start()
    {   
        //Set to halfway (180), then the incremental loop completes the rotation
        //We need to use a vector three and change the Z value
        spriteTransform.DORotate(new Vector3(0,0,180), animDuration).SetEase(animEase).SetLoops(-1, LoopType.Incremental);
    }
}
