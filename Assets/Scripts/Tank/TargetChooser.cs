using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(TankShooting))]
public class TargetChooser : MonoBehaviour{
    
    [SerializeField] List<Transform> _targets = new List<Transform>();
    
    TankShooting _cachedTankShooter;
    Transform _currentTarget;
    bool _isActive;
    void Awake(){
        _cachedTankShooter = GetComponent<TankShooting>();
    }

    void Update(){
        if(_isActive) return;
        if(_currentTarget != null) return;
        ChooseTarget();
    }
    void ChooseTarget(){
        if(_targets.Count == 0) {
            //Request New Wave
            Debug.Log("NotEnoughTargets lul Initializing New Wave");
            _isActive = false;
            return;
        }
        
        Transform tempTarget = _targets[0]; 
        float minDistance = 1000000;
        
        for (int i = 0; i < _targets.Count; i++){
            if(Vector3.Distance(transform.position,_targets[i].position)<minDistance){
                minDistance = Vector3.Distance(transform.position,_targets[i].position);
                tempTarget = _targets[i];
            }
        }
        _targets.Remove(tempTarget);
        _currentTarget = tempTarget;
        _cachedTankShooter.ShootAt(tempTarget);

    }

    public void SetTargets(List<Transform> targets){
        _targets = targets;
        _isActive = true;
    }
}
