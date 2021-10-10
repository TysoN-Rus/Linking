using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Linking
{
    public class MovingConnectable : IMovingConnectable
    {

        private IMyInput myInput;
        private string nameBottom;

        private Transform selectObject;

        public UnityAction<Transform> EvMovingPin { get; set; }

        public MovingConnectable(IMyInput myInput, string nameBottom)
        {
            this.myInput = myInput;
            this.nameBottom = nameBottom;

            this.myInput.EvDown += Select;
            this.myInput.EvUp += Cansel;
            this.myInput.EvPress += Moving;
        }

        private void Select(RaycastHit hit)
        {
            if (hit.transform != null && hit.transform.name == nameBottom)
                selectObject = hit.transform.parent;
        }
        private void Cansel(RaycastHit hit) => selectObject = null;

        private void Moving(RaycastHit hit)
        {
            if (selectObject)
            {
                selectObject.position = myInput.GetPositionZeroPlane();
                EvMovingPin?.Invoke(selectObject);
            }
        }
    }
}