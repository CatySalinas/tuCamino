using UnityEngine;

public class ClockController : MonoBehaviour
{
    public GameObject Segundero;
    public GameObject Minutero;
    public Animation anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animation>();
        if (Segundero == null || Minutero == null)
        {
            Debug.LogError("ERROR EN OBJETO: Reloj roto");
        }
        //Debug
        //startCycle();
    }

    public void startCycle()
    {
        Segundero.GetComponent<ClockAnimation>().startCycle();
        Minutero.GetComponent<ClockAnimation>().startCycle();
    }


    public void stopAll()
    {
        Segundero.GetComponent<ClockAnimation>().stop();
        Minutero.GetComponent<ClockAnimation>().stop();
        anim.Play();
    }
}
