using UnityEngine;

public class WalkCycle : MonoBehaviour
{
    void RotateCharacter()
    {
        Vector3 forward = gameObject.transform.forward;
        gameObject.transform.position = gameObject.transform.position + forward * 0.35f;

        Vector3 currentRotation = gameObject.transform.localEulerAngles;
        gameObject.transform.localEulerAngles = new Vector3(currentRotation.x, currentRotation.y + 180f, currentRotation.z);
        currentRotation.y += 180f;
    }
}
