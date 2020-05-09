using UnityEngine;

public class CubeBehavior : MonoBehaviour {
    public float speed = 10.0f;

    // Update is called once per frame
    void Update() {
        transform.position += new Vector3(Input.acceleration.x, Input.acceleration.y, 0.0f) * speed * Time.deltaTime;
        
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);
        if (viewportPos.x < 0.0) {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, viewportPos.y, viewportPos.z));
        }
        else if (viewportPos.x > 1.0) {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, viewportPos.y, viewportPos.z));;
        }
        
        if (viewportPos.y < 0.0) {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(viewportPos.x, 0.0f, viewportPos.z));
        }
        else if (viewportPos.y > 1.0) {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(viewportPos.x, 1.0f, viewportPos.z));;
        }
    }
}
