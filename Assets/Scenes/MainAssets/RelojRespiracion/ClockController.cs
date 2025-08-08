using UnityEngine;

public class ClockController : MonoBehaviour
{
    public GameObject Segundero;
    public GameObject Minutero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
}
