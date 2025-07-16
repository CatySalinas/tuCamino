using System;
using UnityEngine;

public class TrellaCustomizer : MonoBehaviour{

    public Renderer targetBodyPart;

    public string[] BodyColorHex = new string[] { "#67CFFF", "#9A8FFF", "#FF8541", "#FFF054" };
    public string[] AccesoryColorHex = new string[] { "#3570B8", "#6D38B8", "#B35B00", "#B9980E" };


    public int ColorIndex = 0; 
    public bool isBody;

    public void PressNext(){
        ColorIndex = (ColorIndex + 1) % BodyColorHex.Length;
        ApplyColor();
    }
    public void PressPrev(){
        ColorIndex = (ColorIndex - 1 + BodyColorHex.Length) % BodyColorHex.Length;
        ApplyColor();
    }

    private void ApplyColor(){

        string HexColor = isBody ? BodyColorHex[ColorIndex] : AccesoryColorHex[ColorIndex];

        ColorUtility.TryParseHtmlString(HexColor, out Color colorToApply);

        targetBodyPart.material.color = colorToApply;

    }
}
