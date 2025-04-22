using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    [ReadOnlyAtribute][SerializeField] Rigidbody2D rb;
    [ReadOnlyAtribute][SerializeField] Transform tf;
    [ReadOnlyAtribute][SerializeField] GameObject target;
    [ReadOnlyAtribute][SerializeField] bool grabing;
    [ReadOnlyAtribute][SerializeField] float magnitude;
    [ReadOnlyAtribute][SerializeField] float push;
    [ReadOnlyAtribute][SerializeField] Vector3 pushDir;

    [Header("Interaction options")]
    [SerializeField] Vector3 objectOffset;
    [SerializeField] float range = 10f;
    [SerializeField] float maxPush = 10f;


    [Header("Config")]
    [SerializeField] bool drawRangeGizmo = true;
    [SerializeField] Vector3 offset = new Vector3(0.4F, 0, 0);
    [SerializeField] LayerMask layermask;
    [SerializeField] InputActionReference grab;



    Vector3 rotOffset1;
    Vector3 rotOffset2;
    Vector3 rotOffset3;

    Vector3 objRotOffset;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grabing)
        {
            objRotOffset = tf.rotation * objectOffset;

            pushDir = tf.position + objRotOffset - target.GetComponentInParent<Transform>().position;
            magnitude = pushDir.magnitude;
            push = math.min(magnitude, maxPush);

            target.GetComponentInParent<Rigidbody2D>().gameObject.GetComponent<Transform>().position += push * 0.99f * pushDir.normalized;
        }
    }

    void OnEnable()
    {
        grab.action.started += GrabAttempt;
    }

    void OnDisable()
    {
        grab.action.started -= GrabAttempt;
    }

    private void GrabAttempt(InputAction.CallbackContext obj)
    {
        Debug.Log("Attemped grab");
        if (target != null)
            releaseTarget();
        else
            raycast();

        if (target != null)
        {
            grabTarget();
        }
    }

    void grabTarget()
    {
        grabing = true;
        target.GetComponentInChildren<BoxCollider2D>().enabled = false;
    }

    void releaseTarget()
    {
        target.GetComponentInChildren<BoxCollider2D>().enabled = true;
        grabing = false;
        target = null;
    }

    private void raycast()
    {
        Debug.Log("Attemped Raycast");
        //rotOffset1 = tf.rotation * new Vector3(offset.x, offset.y, offset.z);
        rotOffset2 = tf.rotation * new Vector3(0, offset.y, offset.z);
        //rotOffset3 = tf.rotation * new Vector3(-offset.x, offset.y, offset.z);

        RaycastHit2D hit = Physics2D.Raycast(transform.position + rotOffset2, (tf.rotation * new Vector3(0F, 1F, 0F) * range), range, layermask);
        if (hit.collider != null)
        {
            target = hit.collider.gameObject;
            Debug.Log("Found object");
        }
    }

    void OnDrawGizmos()
    {
        if (drawRangeGizmo)
        {
            rotOffset2 = tf.rotation * new Vector3(0, offset.y, offset.z);
            Gizmos.color = Color.red;

            //Gizmos.DrawLine(tf.position + rotOffset1, tf.position + rotOffset1 + (tf.rotation * new Vector3(0F, 1F, 0F) * range));
            Gizmos.DrawLine(tf.position + rotOffset2, tf.position + rotOffset2 + (tf.rotation * new Vector3(0F, 1F, 0F) * range));
            //Gizmos.DrawLine(tf.position + rotOffset3, tf.position + rotOffset3 + (tf.rotation * new Vector3(0F, 1F, 0F) * range));
        }
    }
}
