using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int _playerHealth = 100;

    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }
        set
        {
            _playerHealth = value;
        }
    }

    private void Start()
    {
        TakeDamage();
        Debug.Log(PlayerHealth);
    }

    void TakeDamage()
    {
        PlayerHealth -= 10;
    }

    int ShowDamage()
    {
        PlayerHealth -= 10;
        return PlayerHealth;
    }
}