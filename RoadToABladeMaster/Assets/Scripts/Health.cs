using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHP = 100.0f;
    private float startHP = 1.0f;
    public float currentHP;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = startHP;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Health " + currentHP);
    }

    public void Points(float damage)
    {
        currentHP += damage;
    }
}
