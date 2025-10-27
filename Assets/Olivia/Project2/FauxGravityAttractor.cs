using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{
    public float gravity = -1.0f;
    public void Attract(Transform body)
    {
        Transform transform = gameObject.transform;
        Vector3 gravityUp = (transform.position - body.position).normalized;
        Vector3 objectUp = transform.up;

        gameObject.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);
        Quaternion targetRotation = Quaternion.FromToRotation(objectUp, gravityUp) * transform.rotation;
        gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 50.0f * Time.deltaTime);
    }
}