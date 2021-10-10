using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class SelectionMethodCliked : SelectionMethod
    {
        protected override void Subscription()
        {
            myInput.EvDown += Down;
            myInput.EvUp += Up;
        }

        private Transform tr;

        private void Down(RaycastHit hit)
        {
            tr = null;
            if (hit.transform && hit.transform.name == namePin)
                tr = hit.transform;
        }
        private void Up(RaycastHit hit)
        {
            if (tr != null && tr == hit.transform)
            {
                //Debug.Log("ClikedUP");
                EvSelect?.Invoke(GetWhatPin(tr));
                tr = null;
            }
            else if (hit.transform == null)
            {
                //Debug.Log("ClikedSpase");
                EvSpase?.Invoke();
            }
        }
    }
}