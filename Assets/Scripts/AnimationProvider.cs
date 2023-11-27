using System;
using UnityEngine;
using UnityEngine.UI;

public class AnimationProvider : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Button _danceButton;
    [SerializeField] private Slider _movementSlider;

    private void Start()
    {
        _danceButton.onClick.AddListener(Dance);
        _movementSlider.onValueChanged.AddListener(MoveCharacter);
    }

    private void MoveCharacter(float sliderValue)
    {
        _animator.SetFloat("MovementSpeed", sliderValue);
    }

    private void OnDestroy()
    {
        _danceButton.onClick.RemoveListener(Dance);
        _movementSlider.onValueChanged.RemoveListener(MoveCharacter);
    }

    private void Dance()
    {
        _animator.SetTrigger("Dance");
    }
}
