using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Oscillogram : MonoBehaviour
{
    [SerializeField] new ParticleSystem particleSystem;
    [SerializeField] new Rigidbody rigidbody;
    int frequency = 100;
    [SerializeField] [Tooltip("跳動時施加的力")] float amplitude;
    [SerializeField] UnityEvent beatEvent;
    float lastTime;

    void FixedUpdate()
    {
        particleSystem.Emit(1);
        particleSystem.Simulate(Time.fixedDeltaTime, true, false);
        if (Time.fixedTime - lastTime > 60.0f / frequency)
        {
            beatEvent.Invoke();
            rigidbody.AddForce(Vector3.up * amplitude);
            lastTime = Time.fixedTime;
        }
    }
}
