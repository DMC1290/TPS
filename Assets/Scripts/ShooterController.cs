using Unity.Cinemachine;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private CinemachineCamera aimCamera;
    [SerializeField] private GameObject aimingPanel;
    [SerializeField] private GameObject spotter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _inputs = GetComponent<AlienInputController>();
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        aimCamera.Priority = _inputs.IsAiming ? 100 : 0;
        aimingPanel.SetActive(_inputs.IsAiming ? true : false);

        if (Physics.Raycast(ray.origin))
        {
            
        }
    }
}