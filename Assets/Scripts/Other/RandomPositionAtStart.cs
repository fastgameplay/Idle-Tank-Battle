using UnityEngine;

public class RandomPositionAtStart : MonoBehaviour{
    [SerializeField] Vector3 _wiggleRoom;

    void Start(){
        transform.position = new Vector3(
            transform.position.x + Random.Range(-_wiggleRoom.x,_wiggleRoom.x),
            transform.position.y + Random.Range(-_wiggleRoom.y,_wiggleRoom.y),
            transform.position.z + Random.Range(-_wiggleRoom.z,_wiggleRoom.z)
        );
        Destroy(this);
    }
}
