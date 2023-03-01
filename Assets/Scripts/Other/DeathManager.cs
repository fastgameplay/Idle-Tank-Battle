using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] bool _isDestroyable;
    [SerializeField] GameObject _deathParticlePrefab;

    IDeathHandler _deathHandler;

    void Awake(){
        if(_isDestroyable){
            _deathHandler = new Destroyable();
        } 
        else{
            _deathHandler = new NonDestroyable();
        }
    }
    public void Destroy(){
        _deathHandler.Death();
        
        if(_deathParticlePrefab != null){
            Instantiate(_deathParticlePrefab,transform.position, Quaternion.identity);
        }
    }
}
