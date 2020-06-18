using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorReflectionProbeController : MonoBehaviour
{
    [SerializeField] Transform floor;
    ReflectionProbe probe;
    
    void Start() {
        this.probe = GetComponent<ReflectionProbe>();
    }
    
    void Update () {
        this.probe.transform.position = new Vector3(
            Camera.main.transform.position.x, 
            floor.position.y - ( Camera.main.transform.position.y - floor.position.y), 
            Camera.main.transform.position.z
        );

        probe.RenderProbe();
    }
}
