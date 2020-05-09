using UnityEngine;
using UnityEngine.UI;

public class ScreenBehavior : MonoBehaviour {

    public Text rotX;
    public Text rotY;
    public Text rotZ;

    // Update is called once per frame
    void Update() {
        rotX.text = "Rotation X: " + Input.acceleration.x;
        rotY.text = "Rotation Y: " + Input.acceleration.y;
        rotZ.text = "Rotation Z: " + Input.acceleration.z;
    }
}
