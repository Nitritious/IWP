using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public static int EnemiesAlive = 0;

    public float speed;

    public float startHealth = 100;
    private float health;

    public int killValue = 50;

    public GameObject deathEffect;

    public Image healthBar;

    private bool isDead = false;
    void Start()
    {
        health = startHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;  

        PlayerStats.Money += killValue;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
    }

    
}
