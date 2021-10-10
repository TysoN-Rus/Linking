using UnityEngine.Events;
using UnityEngine;

namespace Linking
{
    public interface ISelectionMethod
    {
        void Initialization(IMyInput myInput, string namePin);
        UnityAction<int> EvSelect { get; set; }
        UnityAction<int> EvExitPin { get; set; }
        UnityAction EvSpase { get; set; }
        UnityAction<Vector3> EvPosition { get; set; }
    }
}