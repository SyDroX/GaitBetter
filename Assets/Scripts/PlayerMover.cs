using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Transform _transform;
    private float _minY;
    
    [SerializeField] private float _forwardSpeed = 1;
    [SerializeField] private float _footArcHeight = 1;
    [SerializeField] private float _footArcSpeed = 1;
    [SerializeField] private Transform _leftFoot;
    [SerializeField] private Transform _rightFoot;
    
    private void Awake()
    {
        _transform = transform;
        // Assuming both feet have the same minimum Y value. Left is taken arbitrarily
        _minY = _leftFoot.transform.localPosition.y;
    }

    private void Update()
    {
        _transform.Translate(Vector3.forward * _forwardSpeed * Time.deltaTime, Space.Self);
        float footArc = Mathf.Sin(_transform.position.z * _footArcSpeed);
        SetFootPosition(_leftFoot, footArc);
        SetFootPosition(_rightFoot, -footArc);
    }

    private void SetFootPosition(Transform foot, float footArc)
    {
        Vector3 position = foot.localPosition;
        foot.localPosition = new Vector3(position.x, Mathf.Max(0, footArc) * _footArcHeight + _minY, position.z);
    }
}
