using Unity.Mathematics;
using UnityEngine;

public class Atributes : MonoBehaviour
{
    [ReadOnlyAtribute][SerializeField] Animator animator;

    [SerializeField] Transform shakeTransform;

    [SerializeField] float shakeDuration = 0.4f;
    [SerializeField] float shakeAmount = 0.05f;
    [ReadOnlyAtribute][SerializeField] float shakeTime = 0f;

    [SerializeField] float health;
    [SerializeField] float maxHealth;
    [SerializeField] bool destroyOnDeath = true;


    public float getHealth()
    {
        return health;
    }

    public float getMaxHealth()
    {
        return maxHealth;
    }

    /// <summary>
    /// Positive values = heal ;
    /// Negative values = hurt ;
    /// </summary>
    /// <param name="val"></param>
    public void genericHeathEffect(float val)
    {
        if (val > 0)
        {
            heal(val);
        }
        else if (val < 0)
        {
            hurt(-val);
        }
    }

    public void Die()
    {
        Debug.Log(gameObject.name + " death attempt");
        if (destroyOnDeath)
        {
            Destroy(gameObject);
        }
        else
        {
            setHealth(0, true);
        }
    }

    /// <summary>
    /// Only positive values
    /// </summary>
    /// <param name="val"></param>
    public void heal(float val)
    {
        Debug.Log(gameObject.name + " heal attempt");
        health = math.min(health + val, maxHealth);
    }
    /// <summary>
    /// Only positive values
    /// </summary>
    /// <param name="val"></param>
    /// <param name="overheal"></param>
    public void heal(float val, bool overheal)
    {
        Debug.Log(gameObject.name + " (over)heal attempt");
        health += val;
    }

    /// <summary>
    /// Only positive values
    /// </summary>
    /// <param name="val"></param>
    public void hurt(float val)
    {
        Debug.Log(gameObject.name + " hurt attempt");
        health -= val;

        if (health <= 0)
        {
            Die();
        }

        animator.SetTrigger("Dmg");
        shake();
    }

    void shake()
    {
        shakeTime = shakeDuration;
    }

    void setHealth(float val)
    {
        health = math.min(val, maxHealth);

        if (health <= 0)
        {
            Die();
        }
    }
    void setHealth(float val, bool overheal)
    {
        health = val;

        if (health <= 0)
        {
            Die();
        }
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeTime > 0)
        {
            shakeTime -= Time.deltaTime;
            if (shakeTime <= 0)
            {
                shakeTransform.localPosition = new Vector3(0, 0, 0);
            }
            else
            {
                shakeTransform.localPosition = new Vector3(
                    0 + UnityEngine.Random.Range(-shakeAmount, shakeAmount),
                    0 + UnityEngine.Random.Range(-shakeAmount, shakeAmount),
                    0
                );
            }
        }

    }
}
