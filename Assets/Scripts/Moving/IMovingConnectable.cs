using UnityEngine;
using UnityEngine.Events;

namespace Linking
{
    public interface IMovingConnectable
    {
        UnityAction<Transform> EvMovingPin { get; set; }
    }
}