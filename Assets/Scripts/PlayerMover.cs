using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] private float speed;
    

    void Awake()
    {
        _transform = transform;
    }
    // Update is called once per frame
    void Update()
    {
        _transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
