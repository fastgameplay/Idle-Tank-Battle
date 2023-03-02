using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTowerAim : MonoBehaviour
{
    public Transform Target{
        get{
            return _target;
        }
        set{
            _target = value;
        }
    }
    Transform _target;
    
    void Update(){
        AimTowerHorizontal();
    }
    void AimTowerHorizontal(){
        if(_target != null){
            transform.LookAt(new Vector3(_target.position.x, transform.position.y, _target.position.z));
        }
    }
}
