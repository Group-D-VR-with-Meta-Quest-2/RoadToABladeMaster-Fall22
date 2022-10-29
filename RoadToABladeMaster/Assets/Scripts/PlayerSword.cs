using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSword : MonoBehaviour
{
    public Health HP_Component;

    public Health Player_HP_Component;

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
        other.tag = "Enemy";
        if (other.tag == HP_Component.tag)
        {
            var hpComponent = Player_HP_Component.GetComponent<Health>();

            hpComponent.Points(1);

            //Debug.Log("Works ps");
        }
    }
}
