using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySword : MonoBehaviour
{
    public Health HP_Component;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        other.tag = "Player";
        if (other.tag == HP_Component.tag)
        {
            var hpComponent = HP_Component.GetComponent<Health>();

            hpComponent.TakeDamage(1);

            Debug.Log("Works es");
        }
    }
}
