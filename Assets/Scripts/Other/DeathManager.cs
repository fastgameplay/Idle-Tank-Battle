using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] bool _isDestroyable;

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
    }
}
