using UnityEngine;

[RequireComponent(typeof(BulletMovement))]
[RequireComponent(typeof(BulletColision))]
[RequireComponent(typeof(DeathManager))]

public class Bullet : MonoBehaviour{
    BulletMovement _cachedBulletMovement;
    BulletColision _cachedBulletColision;
    DeathManager _cachedDeathManager;
    public int Damage{set{_cachedBulletColision.SetDamage(value);}}
    Transform _trackedTransform;
    bool _isOperable;
    void Awake(){
        _cachedBulletMovement = GetComponent<BulletMovement>();
        _cachedBulletColision = GetComponent<BulletColision>();
        _cachedDeathManager = GetComponent<DeathManager>();
    }
    void Update(){
        if(_isOperable){
            if(_trackedTransform == null){
                _cachedDeathManager.Destroy();
            }
        }
    }
    public Bullet Shoot(Transform target){
        _trackedTransform = target;
        _isOperable = true;
        transform.LookAt(target);
        _cachedBulletMovement.Target = target;
        return this;
    }
}
