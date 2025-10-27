using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    public float Speed = 5.0f;
    void Update()
    {
        Vector3 currentRotation = gameObject.transform.localEulerAngles;
        gameObject.transform.localEulerAngles = new Vector3(0f, currentRotation.y + Time.deltaTime * Speed, 0f);
    }
}
