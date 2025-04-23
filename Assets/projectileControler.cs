using UnityEngine;

public class projectileControler : MonoBehaviour
{

    [ReadOnlyAtribute][SerializeField] Collider2D damageColision;
    [ReadOnlyAtribute][SerializeField] Collider2D physicsColision;
    [ReadOnlyAtribute][SerializeField] Collider2D rayTracableColider;
    [SerializeField] float damage;

    [Header(" Non projectiles properties ")]
    [SerializeField] float _nppLinearDamp = 2f;
    [SerializeField] float _nppAngularDamp = 10f;
    [SerializeField] float _nppMass = 10f;

    [Header(" projectiles properties ")]
    [SerializeField] float linearDamp = 0.1f;
    [SerializeField] float angularDamp = 20f;
    [SerializeField] float mass = 50f;

    void Start()
    {
        damageColision = GetComponent<BoxCollider2D>();
        physicsColision = transform.parent.GetComponent<BoxCollider2D>();
        rayTracableColider = transform.parent.GetComponentInChildren<GrabableObject>().rayTracableColider;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with " + collision.gameObject.name + " detected");

        collision.transform.GetComponent<Atributes>().genericHeathEffect(-damage);
        damageColision.enabled = false;
        disableProjectile();

        GetComponentInParent<Rigidbody2D>().linearVelocity *= -0.5f;
    }

    public void disableProjectile()
    {
        Rigidbody2D rb = GetComponentInParent<Rigidbody2D>();

        rb.linearDamping = _nppLinearDamp;
        rb.angularDamping = _nppAngularDamp;
        rb.mass = _nppMass;

        damageColision.enabled = false;
        physicsColision.enabled = true;
        rayTracableColider.enabled = true;
    }

    public void enableProjectile(bool enemy)
    {
        Rigidbody2D rb = GetComponentInParent<Rigidbody2D>();

        rb.linearDamping = linearDamp;
        rb.angularDamping = angularDamp;
        rb.mass = mass;

        if (enemy)
        {
            damageColision.gameObject.layer = LayerMask.NameToLayer("EnemyAtack");
        }
        else
        {
            damageColision.gameObject.layer = LayerMask.NameToLayer("PlayerAtack");
        }

        damageColision.enabled = true;
        physicsColision.enabled = false;
        rayTracableColider.enabled = false;
    }
}
