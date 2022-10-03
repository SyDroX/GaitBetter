using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private TMP_Text _playerPositionText;
    
    private void LateUpdate()
    {
        TimeSpan timeFromStart = TimeSpan.FromSeconds(Time.timeSinceLevelLoad);
        _timeText.text = timeFromStart.ToString("mm\\:ss");
        _playerPositionText.text = ((int)_player.position.z).ToString();
    }
}
