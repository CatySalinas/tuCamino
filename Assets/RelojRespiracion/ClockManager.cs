using UnityEngine;

public class ClockManager : MonoBehaviour
{
    public AudioSource audioPlayer;
    public Animation anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
        anim = GetComponent<Animation>();

        anim.Play();
    }

    // Update is called once per frame
    void Update()
    {

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
