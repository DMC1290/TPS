using TMPro;
using UnityEngine;

public class AlienMoveController : MonoBehaviour
{
    [SerializeField] public float walkSpeed = 2f;
    [SerializeField] public float runSpeed = 8f;

    [SerializeField] private AlienInputController _inputs;
    private CharacterController _controller;
    private Animator _animator;

    private int _torsoLayerIndex;
    private float _torsoLayerWeight = 0;
    private float _dampVelocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _inputs = GetComponent<AlienInputController>();
        _controller = GetComponent<CharacterController>();
        _animator = GetComponentInChildren<Animator>();

        _torsoLayerIndex = _animator.GetLayerIndex("Torso");
    }

    // Update is called once per frame
    void Update()
    {
        _torsoLayerWeight = Mathf.SmoothDamp(_torsoLayerWeight, _inputs.IsAiming ? 1f : 0f, ref _dampVelocity, 0.05f);

        _animator.SetLayerWeight(_torsoLayerIndex, _torsoLayerWeight);

        // if (_isRootMotioned)
        // {
        //     //Camera
        //
        //     //float turnSpeed = _inputs.IsRunning ? _fastTurnSpeed : _turnSpeed;
        //     // _rootCharacter.Rotate(Vector3.up, _inputs.Move.x * turnSpeed * Time.deltaTime);
        //     float angle = Camera.main.transform.rotation.eulerAngles.y;
        //     angle += Mathf.Atan2(_inputs.Move.x, _inputs.Move.y) * Mathf.Rad2Deg;
        //     
        //     
        //     
        //     _rootCharacter.rotation = Quaternion.Euler(0, angle, 0);
        //
        //     _animator.SetFloat("Speed", _inputs.Move.magnitude);
        // }
        // else
        // {
        //     float turnspeed = _inputs.IsRunning ? _fastTurnSpeed : _turnSpeed;
        //     transform.Rotate(Vector3.up, _inputs.Move.x * turnspeed * Time.deltaTime);
        //
        //     float horizontalspeed = _inputs.IsRunning ? runSpeed : walkSpeed;
        //     _controller.SimpleMove(transform.forward * (_inputs.Move.y * horizontalspeed));
        //
        //     _animator.SetFloat("Speed", _controller.velocity.magnitude);
        // }
    }
}