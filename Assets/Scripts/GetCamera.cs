using Cinemachine;
using Fusion;
using UnityEngine;
using UnityEngine.Rendering;

public class GetCamera : MonoBehaviour
{
    [SerializeField] Transform _toFollow;

    private void Start()
    {
        NetworkObject _myObject = GetComponent<NetworkObject>();

        if (_myObject.HasStateAuthority)
        {
            GameObject _virtualCamera = GameObject.Find("PlayerFollowCamera");
            _virtualCamera.GetComponent<CinemachineVirtualCamera>().Follow = _toFollow;
        }
    }

}
