using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(DeathManager))]
public class BulletColision : MonoBehaviour
{
    
    DeathManager _cachedDeathManager;
    int _cachedDamage;
    void Awake(){
        _cachedDeathManager = GetComponent<DeathManager>();
        
    }
    public void CollidedWith(Transform target){
        if(target.CompareTag("Damagable")){
            Debug.Log("DamageRegistered");
            target.GetComponent<Health>().Damage(_cachedDamage);
        }
        Debug.Log("DestroyThis");
        _cachedDeathManager.Destroy();
    }
    

    public void SetDamage(int value){
        _cachedDamage = value;
    }
}
