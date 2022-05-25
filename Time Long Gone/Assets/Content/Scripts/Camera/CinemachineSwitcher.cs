using Cinemachine;
using UnityEngine;

namespace Content.Scripts.Camera
{
    public class CinemachineSwitcher : MonoBehaviour
    {
        public static CinemachineSwitcher Instance;

        [SerializeField] private CinemachineVirtualCamera altVcam;

        public void Switch(bool x)
        {
            altVcam.gameObject.SetActive(x);
        }
    }
}