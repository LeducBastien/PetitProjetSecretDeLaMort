using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected uint Life { get; set; }
    [SerializeField] protected float Speed { get; set; }
    [SerializeField] protected float Gravity { get; set; }

    protected virtual void Start()
    {
    }

    protected virtual void Update ()
    {
    }
}
