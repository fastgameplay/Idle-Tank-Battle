using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(DeathManager))]
public class BulletColision : MonoBehaviour
{
    [SerializeField] int _tempDamage = 5;
    
    DeathManager _cachedDeathManager;
    void Awake(){
        _cachedDeathManager = GetComponent<DeathManager>();
    }   
    public void CollidedWith(Transform target){
        if(target.CompareTag("Damagable")){
            target.GetComponent<Health>().Damage(_tempDamage);
        }
        _cachedDeathManager.Destroy();
    }

}
