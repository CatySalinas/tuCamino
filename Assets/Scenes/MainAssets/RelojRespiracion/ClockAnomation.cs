using UnityEngine;

public class ClockAnimation : MonoBehaviour
{
    public AudioSource audioPlayer;
    public Animation anim;

    public void startCycle()
    {
        anim.Play();
    }

    public void playTic()
    {
        if (audioPlayer != null)
        {
            audioPlayer.pitch = Random.Range(0.95f, 1.095f);
            audioPlayer.Play();
        }
    }
}
