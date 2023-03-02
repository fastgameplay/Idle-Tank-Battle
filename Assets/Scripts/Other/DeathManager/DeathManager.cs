using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] bool _isDestroyable;
    [SerializeField] GameObject _deathParticlePrefab;

    IDeathHandler _deathHandler;

    void Awake(){
       
    }
    public void Destroy(){
        Destroy(gameObject);
        
        if(_deathParticlePrefab != null){
            Instantiate(_deathParticlePrefab,transform.position, Quaternion.identity);
        }
    }
}
