using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class SelectionMethodDrag : SelectionMethod
    {
        protected override void Subscription()
        {
            myInput.EvDown += Down;
            myInput.EvPress += Press;
            myInput.EvUp += Up;
        }

        private Transform tr;

        private void Down(RaycastHit hit)
        {
            if (hit.transform && hit.transform.name == namePin)
            {
                tr = hit.transform;
                EvSelect?.Invoke(GetWhatPin(tr));
            }
        }

        private bool onExit;

        private void Press(RaycastHit hit)
        {
            if (tr != null)
            {
                if (!onExit && (hit.transform == null || hit.transform.name != namePin))
                {
                    //Debug.Log("DragPressExit");
                    EvExitPin?.Invoke(GetWhatPin(tr));
                    onExit = true;
                }
                if (onExit)
                {
                    if (hit.transform == null)
                        EvPosition?.Invoke(myInput.GetPositionZeroPlane());
                    else
                        EvPosition?.Invoke(hit.point);
                }
            }
        }

        private void Up(RaycastHit hit)
        {
            if (tr != null && hit.transform != null && tr != hit.transform && hit.transform.name == namePin)
            {
                //Debug.Log("DragUP");
                EvSelect?.Invoke(GetWhatPin(hit.transform));
            }

            if (tr == hit.transform && tr != null)
            {
                //Debug.Log("DragSeletOne");
                EvSelect?.Invoke(GetWhatPin(hit.transform));
            }

            if (hit.transform == null || hit.transform.name != namePin)
            {
                //Debug.Log("DragSpase");
                EvSpase?.Invoke();
            }

            tr = null;
            onExit = false;
        }

    }
}