using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    private List<GameObject> _attractors = new List<GameObject>();
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        GetComponent<Rigidbody>().useGravity = false;

        FauxGravityAttractor[] attractorComponents = Object.FindObjectsByType<FauxGravityAttractor>(FindObjectsSortMode.None);
        foreach (FauxGravityAttractor component in attractorComponents)
        {
            _attractors.Add(component.gameObject);
        }
    }


    void Update()
    {
        foreach (GameObject attractor in _attractors)
        {
            FauxGravityAttractor attractorComp = attractor.GetComponent<FauxGravityAttractor>();
            attractorComp.Attract(gameObject.transform);
        }
    }
}