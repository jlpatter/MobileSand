using UnityEngine;

public class CubeBehavior : MonoBehaviour {
    public float speed = 10.0f;
    
    private Rigidbody _rigidbody;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        _rigidbody.MovePosition(transform.position + new Vector3(Input.acceleration.x, Input.acceleration.y, 0.0f) * speed * Time.fixedDeltaTime);
    }
}
