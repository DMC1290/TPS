using System;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float maxHealth = 100;

    private float _currentHealth;

    private void OnEnable()
    {
        _currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        if(_currentHealth <= 0)
            Destroy(gameObject);
    }
    
    
}
