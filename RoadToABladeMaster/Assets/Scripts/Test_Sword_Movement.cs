using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Sword_Movement : MonoBehaviour
{
    public Transform[] Target;
    int CurrentPosition;

    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        CurrentPosition = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != Target[CurrentPosition].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, Target[CurrentPosition].position, Speed * Time.deltaTime);
        }

        else
        {
            CurrentPosition = (CurrentPosition + 1) % Target.Length;
        }
    }
}
