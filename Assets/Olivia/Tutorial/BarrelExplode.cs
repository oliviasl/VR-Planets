using UnityEngine;

public class BarrelExplode : MonoBehaviour
{
    public float ExplosionForce = 1000.0f;

    [SerializeField] private ParticleSystem particles;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particles.Play();

            Vector3 explodeDir = gameObject.transform.position - other.transform.position + Vector3.up;
            explodeDir.Normalize();

            rb.AddExplosionForce(ExplosionForce, gameObject.transform.position - Vector3.up - explodeDir * 0.3f, 5.0f);
            rb.AddForce(explodeDir * ExplosionForce);
        }
    }
}
