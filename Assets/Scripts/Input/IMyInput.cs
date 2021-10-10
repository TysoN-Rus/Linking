using UnityEngine;
using UnityEngine.Events;

namespace Linking
{
    public interface IMyInput
    {
        UnityAction<RaycastHit> EvDown { get; set; }
        UnityAction<RaycastHit> EvUp { get; set; }
        UnityAction<RaycastHit> EvPress { get; set; }
        UnityAction<Vector2> EvWASD { get; set; }
        Ray GetRay();
        Vector3 GetPositionZeroPlane();
    }
}