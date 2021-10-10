using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Linking
{
    public abstract class SelectionMethod : ISelectionMethod
    {
        protected IMyInput myInput;
        protected string namePin;

        public void Initialization(IMyInput myInput, string namePin)
        {
            this.myInput = myInput;
            this.namePin = namePin;
            Subscription();
        }

        public UnityAction<int> EvSelect { get; set; }
        public UnityAction<int> EvExitPin { get; set; }
        public UnityAction EvSpase { get; set; }
        public UnityAction<Vector3> EvPosition { get; set; }

        protected int GetWhatPin(Transform tr) => MyMethods.GetWhatID(tr.parent);

        protected abstract void Subscription();

    }
}