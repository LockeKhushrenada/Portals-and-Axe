using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineSwitcher : MonoBehaviour
{
    [SerializeField]
    private CinemachineFreeLook freeLookCam1;
    [SerializeField]
    private CinemachineFreeLook freeLookCam2;
    private bool notAiming = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(Input.GetKeyDown(KeyCode.LeftControl))
        {
            notAiming = true;
        }
    }

    private void SwitchPriority()
    {
        if (notAiming)
        {
            freeLookCam1.Priority = 0;
            freeLookCam2.Priority = 1;
        }
        else
        {
            freeLookCam1.Priority = 1;
            freeLookCam2.Priority = 0;
        }
        notAiming = !notAiming;
    }
}
