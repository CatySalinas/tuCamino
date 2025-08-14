using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    //Referencias externas
    public AudioSource AudioSource;
    public AudioClip [] AudioClips;

    //Controladores
    public float MusicVolume = 1.0f;
    public float MaxWaitTime = 15.0f;
    public float MinWaitTime = 7.5f;

    float timeWaited = 0;
    float timeToWait = Mathf.Infinity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        timeToWait = SetRandomWaitTime();
    }

    // Update is called once per frame
    void Update()
    {
        //Ajusta el volúmen a un valor arbitrario.
        AudioSource.volume = MusicVolume;

        if(timeWaited >= timeToWait)
        {
            //Si ya esperó suficiente tiempo y no hay música, pone algo
            IniciarMusica();
            timeWaited = 0;
            timeToWait = SetRandomWaitTime();
        }
        else if (!AudioSource.isPlaying)
        {
            //Si hay silencio, espera un cierto tiempo
            timeWaited += Time.deltaTime;
            return;
        }
    }

    void IniciarMusica()
    {
        //Pone una cancion de fondo
        SelectTrack();
        AudioSource.Play();
    }

    void SelectTrack()
    {
        //Selecciona una de las canciones como clip para reproducir
        int candidate = Random.Range(0, AudioClips.Length-1);
        AudioSource.clip = AudioClips[candidate];
    }

    float SetRandomWaitTime()
    {
        //Define un tiempo a esperar. Los parámetros se pueden modificar en el editor de unity
        return Random.Range(MinWaitTime, MaxWaitTime);
    }
}
