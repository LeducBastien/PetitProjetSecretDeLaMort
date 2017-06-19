using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    private Entity _player;

    [SerializeField] private uint _distance;

    protected override void Awake()
    {
        base.Awake();
        // _player = GetPlayer;
    }

    protected override void Start ()
    {
        base.Start();
    }


    protected override void Update ()
    {
        base.Update();
	}
}
