using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EarthAnimation : MonoBehaviour {
    void Update() {
        transform.Rotate(Vector3.up, 0.5f);
        float rate = ((float) Math.Sin(Time.time * 0.8f) + 1f) / 2f;
        GetComponent<VisualEffect>().SetFloat("SphereRate", rate);
    }
}