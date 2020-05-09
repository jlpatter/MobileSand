using UnityEngine;

public class CubeBehavior : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        if (!Input.gyro.enabled) {
            Input.gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update() {
        float rotx = Input.acceleration.x;
        float roty = Input.acceleration.y;
        float rotz = Input.acceleration.z;
        transform.rotation = new Quaternion(rotx, roty, rotz, 0);
    }
}
