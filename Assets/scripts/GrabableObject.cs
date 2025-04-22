using UnityEngine;

public class GrabableObject : MonoBehaviour
{

    [SerializeField] public Transform parentTransform;
    [SerializeField] public BoxCollider2D rayTracableColider;
    [SerializeField] public Vector3 grabOffset = new Vector3(0, 0, 0);

    [SerializeField]
    public void grab()
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (parentTransform == null)
            parentTransform = GetComponent<Transform>().parent.GetComponent<Transform>();
        if (rayTracableColider == null)
            rayTracableColider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
