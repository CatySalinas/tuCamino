using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform playerCamera;
    public Vector3 localOffset = new Vector3(-3.5f, -6f, 2f);

    void Start()
    {
        transform.SetParent(playerCamera);
        transform.localPosition = localOffset;


    }
}
