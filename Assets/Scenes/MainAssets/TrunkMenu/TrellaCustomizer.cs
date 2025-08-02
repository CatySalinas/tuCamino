using System;
using UnityEngine;

public class TrellaCustomizer : MonoBehaviour{

    //Field in inspector to drag dsired body parth to change
    public Renderer targetBodyPart;

    //Colors
    public string[] BodyColorHex = new string[] { "#67CFFF", "#9A8FFF", "#FF8541", "#FFF054" };
    public string[] AccesoryColorHex = new string[] { "#3570B8", "#6D38B8", "#B35B00", "#B9980E" };

    //Index for later accesing the colors
    public int ColorIndex = 0; 
    //Is it the body?
    public bool isBody;

    public void PressNext(){
        //When a "Next" button is pressed, progress forward in the array, when reached the "front"
        //Of the array, it module sets it back to 3
        ColorIndex = (ColorIndex + 1) % BodyColorHex.Length;
        ApplyColor();

    }
    public void PressPrev(){
        //When a "Next" button is pressed, progress backwards in the array, when reached the "back"
        //Of the array, it module sets it back to 3
        ColorIndex = (ColorIndex - 1 + BodyColorHex.Length) % BodyColorHex.Length;
        ApplyColor();
    }

    private void ApplyColor(){
        
        //Is the targetBodyPart the body? If yes, apply the color in BodyColorHex
        // If no, apply the color in AccesoryColorHex to targetBodyPart
        string HexColor = isBody ? BodyColorHex[ColorIndex] : AccesoryColorHex[ColorIndex];

        //Gets the desire color
        ColorUtility.TryParseHtmlString(HexColor, out Color colorToApply);

        //Sets the desire color
        targetBodyPart.material.color = colorToApply;

    }
}
