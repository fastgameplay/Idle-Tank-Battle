using UnityEngine;
[RequireComponent(typeof(BulletColision))]
public class BulletMovement : MonoBehaviour{
    
    public Transform Target{ 
        get
        { 
            return _target;
        } 
        set
        {
            _target = value;
            _isMoving = true;
        }
    }
    private Transform _target;

    [SerializeField]
    private float _speed;

    private BulletColision _cachedColisionHandler;
    private bool _isMoving;

    void Awake()
    {
        _cachedColisionHandler = GetComponent<BulletColision>();
    }

    void Update()
    {
        if(_target == null) return;
        if(_isMoving){
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);

            if(Vector3.Distance(transform.position,_target.position) < 0.5f){
                _cachedColisionHandler.CollidedWith(_target);
            }

        }
        
    }
    
}
