using UnityEngine;

namespace Linking
{
    public interface IColoring
    {
        void ColoringAllOption();
        void ColoringSelect(int val, bool select = true);
        void ColoringAllNormal();
        Transform GetTransform(int val);
    }
}