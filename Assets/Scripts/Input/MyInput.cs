using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Linking
{
    public class MyInput : IMyInput
    {
        private Camera cameraMain;
        private MonoBehaviour mono;

        private InputControll input;
        private IEnumerator coroutine;

        private LayerMask layerMask;

        private Ray ray;

        public MyInput(Camera cameraMain, MonoBehaviour mono, LayerMask layerMask)
        {
            this.cameraMain = cameraMain;
            this.mono = mono;
            this.layerMask = layerMask;
            input = new InputControll();
            input.KeyboardMouse.Down.started += x => Down();
            input.KeyboardMouse.Down.canceled += x => Up();
            input.KeyboardMouse.WASD.started += x => EvWASD.Invoke(input.KeyboardMouse.WASD.ReadValue<Vector2>());
            input.Enable();
        }

        public UnityAction<RaycastHit> EvDown { get; set; }
        public UnityAction<RaycastHit> EvUp { get; set; }
        public UnityAction<RaycastHit> EvPress { get; set; }
        public UnityAction<Vector2> EvWASD { get; set; }

        private void Down()
        {
            EvDown?.Invoke(GetRaycastHit());
            StartPress();
        }
        private void Up()
        {
            EvUp?.Invoke(GetRaycastHit());
            StopPress();
        }

        private RaycastHit GetRaycastHit()
        {
            RaycastHit hit;
            ray = cameraMain.ScreenPointToRay(input.KeyboardMouse.PositionMouse.ReadValue<Vector2>());
            Physics.Raycast(ray, out hit, float.MaxValue, layerMask);
            return hit;
        }
        public Ray GetRay() => ray;
        public Vector3 GetPositionZeroPlane()
        {
            Vector3 newPosition = Vector3.zero;
            newPosition.x = -ray.origin.y / ray.direction.y * ray.direction.x + ray.origin.x;
            newPosition.z = -ray.origin.y / ray.direction.y * ray.direction.z + ray.origin.z;

            return newPosition;
        }

        private void StopPress()
        {
            if (coroutine == null) return;

            mono.StopCoroutine(coroutine);
            coroutine = null;
        }

        private void StartPress()
        {
            if (coroutine != null) mono.StopCoroutine(coroutine);

            coroutine = Scrolling();
            mono.StartCoroutine(coroutine);
        }
        private IEnumerator Scrolling()
        {
            while (true)
            {
                yield return null;
                EvPress?.Invoke(GetRaycastHit());
            }
        }

    }
}


