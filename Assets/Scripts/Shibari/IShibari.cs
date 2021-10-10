using UnityEngine;

namespace Linking
{
    public interface IShibari
    {
        void CreateRope(Transform pinOne, Transform pinTwo);
        void UpdaetLink();
        void CreateTempRope(Transform pinOne, Transform pinTwo);
        void ClearTempRope();
    }
}