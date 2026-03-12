using Cinemachine;
using UnityEngine;

public class GetCamera : MonoBehaviour
{
    [SerializeField] Transform _toFollow;

    private void Awake()
    {
        GameObject _virtualCamera = GameObject.Find("PlayerFollowCamera");
        _virtualCamera.GetComponent<CinemachineVirtualCamera>().Follow = _toFollow;
    }

}
