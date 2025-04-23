using UnityEngine;

public class GrabableObject : MonoBehaviour
{

    [SerializeField] public Transform parentTransform;
    [SerializeField] public BoxCollider2D rayTracableColider;
    [SerializeField] public projectileControler projectileControler;
    [SerializeField] public Vector3 grabOffset = new Vector3(0, 0, 0);

    public void grab()
    {

    }

    public void shoot(Vector2 direction, float magnitude, bool enemy)
    {
        Debug.Log("attempted shooting \"" + gameObject.name + "\" in direction (" + direction + ") with magnitude (" + magnitude + ") as: " + (enemy ? "enemy" : "player"));
        if (projectileControler != null)
        {
            projectileControler.enableProjectile(enemy);
            Rigidbody2D rb = GetComponentInParent<Rigidbody2D>();
            rb.AddForce(direction * magnitude, ForceMode2D.Impulse);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (parentTransform == null)
            parentTransform = GetComponent<Transform>().parent.GetComponent<Transform>();
        if (rayTracableColider == null)
            rayTracableColider = GetComponent<BoxCollider2D>();
        if (projectileControler == null)
            projectileControler = GetComponent<Transform>().parent.GetComponentInChildren<projectileControler>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
