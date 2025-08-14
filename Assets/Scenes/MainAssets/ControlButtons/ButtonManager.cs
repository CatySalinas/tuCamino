using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public Animation anim; //Clip de animacion
    public GameObject parent; //Requiere ser el padre Prefab

    public void Interact()
    {
        //Anima la interacción
        anim.Play();
    }
    public void Hide()
    {
        //Una vez termina la animación, se esconde
        parent.SetActive(false);
    }

}
