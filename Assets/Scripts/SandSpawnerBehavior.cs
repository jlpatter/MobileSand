using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandSpawnerBehavior : MonoBehaviour {
    public GameObject sandGrain;

    void Start() {
        for (float i = -2.0f; i < 2.0f; i += 0.2f) {
            for (float j = -2.0f; j < 2.0f; j += 0.2f) {
                Instantiate(sandGrain, new Vector3(i, j, 0.0f), Quaternion.identity);
            }
        }
    }
}
