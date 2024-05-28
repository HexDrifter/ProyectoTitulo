using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    using Cinemachine;
    using Domain;
    public class CinemachineCameraService : ICameraService
    {
        private readonly CinemachineVirtualCamera _virtualCamera;

        public CinemachineCameraService(CinemachineVirtualCamera virtualCamera)
        {
            _virtualCamera = virtualCamera;
        }

        public void TargetActor(Transform t)
        {
            _virtualCamera.Follow = t;
            _virtualCamera.LookAt = t;
        }
    }
}
