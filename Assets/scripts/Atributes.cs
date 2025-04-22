using Unity.Mathematics;
using UnityEngine;

public class Atributes : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth;


    public float getHealth()
    {
        return health;
    }

    public float getMaxHealth()
    {
        return maxHealth;
    }

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
    }

    void heal(float val)
    {
        Debug.Log(gameObject.name + " heal attempt");
        health = math.min(health + val, maxHealth);
    }
    void heal(float val, bool overheal)
    {
        Debug.Log(gameObject.name + " (over)heal attempt");
        health += val;
    }

    void hurt(float val)
    {
        Debug.Log(gameObject.name + " hurt attempt");
        health -= val;

        if (health <= 0)
        {
            Die();
        }
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

    }

    // Update is called once per frame
    void Update()
    {

    }
}
