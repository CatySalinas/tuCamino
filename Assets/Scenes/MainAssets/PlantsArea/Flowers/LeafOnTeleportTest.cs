using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Renderer DissapearingAppeareing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTeleport(){
        DissapearingAppeareing.enabled = true;

        Debug.Log("You teleported here");
    }
}
