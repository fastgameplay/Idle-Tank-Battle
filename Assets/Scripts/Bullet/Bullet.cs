using UnityEngine;

[RequireComponent(typeof(BulletMovement))]
[RequireComponent(typeof(BulletColision))]
[RequireComponent(typeof(DeathManager))]

public class Bullet : MonoBehaviour
{
    BulletMovement _cachedBulletMovement;
    BulletColision _cachedBulletColision;
    public int Damage{set{_cachedBulletColision.SetDamage(value);}}
    void Awake(){
        _cachedBulletMovement = GetComponent<BulletMovement>();
        _cachedBulletColision = GetComponent<BulletColision>();
    }
    public Bullet Shoot(Transform target){
        transform.LookAt(target);
        _cachedBulletMovement.Target = target;
        return this;
    }
}
