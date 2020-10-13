using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public Stat maxHealth;
    public int currentHealth { get; protected set; }

    public Stat damage;

    public event System.Action OnHealthReachedZero;

    public virtual void Awake()
    {
        currentHealth = maxHealth.GetValue();
    }

    // Start with maxhealth
    public virtual void Start()
    {
        
    }

    public void TakeDamage (int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {

    }

    public void Heal (int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth.GetValue());
    }
}
