using UnityEngine;
using UnityEngine.UI;

public class AnimationProvider : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Button _danceButton;
    [SerializeField] private Slider _movementSlider;
    [SerializeField] private Button _jumpButton;

    private void Start()
    {
        _jumpButton.onClick.AddListener(Jump); 
        _danceButton.onClick.AddListener(Dance);
        _movementSlider.onValueChanged.AddListener(MoveCharacter);
    }

    private void OnDestroy()
    {
        _danceButton.onClick.RemoveListener(Dance);
        _jumpButton.onClick.RemoveListener(Jump);

        _movementSlider.onValueChanged.RemoveListener(MoveCharacter);
    }

    private void MoveCharacter(float sliderValue)
    {
        _animator.SetFloat("MovementSpeed", sliderValue);
    }

    private void Dance()
    {
        _animator.SetTrigger("Dance");
    }

    private void Jump()
    {
        _animator.SetTrigger("Jump");
    }
}
