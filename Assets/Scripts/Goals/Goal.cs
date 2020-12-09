using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    [SerializeField]
    UnityEvent onTriggerCompleted;
    [SerializeField]
    UnityEvent onTriggerUncompleted;

    IGoalPrecondition condition;

    void Awake(){
        condition = GetComponent<IGoalPrecondition>();
    }
    
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            if(condition.IsMet()){
                onTriggerCompleted.Invoke();
            }
            else{
                onTriggerUncompleted.Invoke();
            }
        }
    }
}
