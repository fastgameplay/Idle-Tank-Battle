using UnityEngine;

[RequireComponent(typeof(BulletMovement))]
[RequireComponent(typeof(BulletColision))]
[RequireComponent(typeof(DeathManager))]

public class Bullet : MonoBehaviour
{
    BulletMovement _cachedBulletMovement;

    void Awake(){
        _cachedBulletMovement = GetComponent<BulletMovement>();
    }
    public void Shoot(Transform target){
        transform.LookAt(target);
        _cachedBulletMovement.Target = target;

    }
}
