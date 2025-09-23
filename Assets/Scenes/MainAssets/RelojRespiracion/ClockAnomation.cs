using System;
using UnityEngine;

public class ClockAnimation : MonoBehaviour
{
    public AudioSource ticAudio;
    public AudioSource inAudio;
    public AudioSource holdAudio;
    public AudioSource outAudio;

    public Animation anim;

    public GameObject Origin;

    public int Vueltas = 3;
    int vueltasDadas = 0;

    public void startCycle()
    {
        anim.Play();
    }

    public void playTic()
    {
        if (ticAudio != null)
        {
            ticAudio.Play();
        }
    }

    public void playIn()
    {
        if (inAudio != null)
        {
            inAudio.Play();
        }
    }
    public void playHold()
    {
        if (holdAudio != null)
        {
            holdAudio.Play();
        }
    }

    public void playOut()
    {
        if (outAudio != null)
        {
            outAudio.Play();
        }
    }
    public void completeCycle()
    {
        vueltasDadas++;
        if (vueltasDadas >= Vueltas)
        {
            Origin.GetComponent<ClockController>().stopAll();
        }
        else
        {
            return;
        }
    }
    public void stop()
    {
        anim.Stop();
    }
}
