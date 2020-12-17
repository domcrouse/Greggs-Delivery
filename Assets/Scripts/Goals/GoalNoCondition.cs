using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalNoCondition : MonoBehaviour, IGoalPrecondition
{
    public bool IsMet() => true;
}
