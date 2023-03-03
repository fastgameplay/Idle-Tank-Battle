using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankMovement : MonoBehaviour
{
    [SerializeField] float _stopLine;

    Vector3 _targetPosition;
    
    void Start(){
        _targetPosition = new Vector3(_stopLine,transform.position.y,transform.position.z);
    }

    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, 4.7f * Time.deltaTime);
    }

}
