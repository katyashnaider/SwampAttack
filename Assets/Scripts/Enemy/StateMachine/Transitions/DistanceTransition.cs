using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTransition : Transition
{
    [SerializeField] private float _transitionRange;
    [SerializeField] private float _rangetSpreat;

    private void Start()
    {
        _transitionRange += Random.Range(-_rangetSpreat, _rangetSpreat);
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, Target.transform.position) < _transitionRange)
            NeedTransit = true;
    }
}
