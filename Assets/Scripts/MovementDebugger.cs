using UnityEngine;

public class MovementDebugger : MonoBehaviour
{
    [SerializeField] private bool _enabled;
    [SerializeField] private TrailRenderer[] _trailRenderers;
    [SerializeField] private Camera _sideCamera;

    private void OnValidate()
    {
        UnityEditor.EditorApplication.delayCall += ToggleDebug;
    }

    private void ToggleDebug()
    {
        foreach (TrailRenderer trailRenderer in _trailRenderers)
        {
            trailRenderer.gameObject.SetActive(_enabled);
        }
        
        _sideCamera.gameObject.SetActive(_enabled);
    }
}
