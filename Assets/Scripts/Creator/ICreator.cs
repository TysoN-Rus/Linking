using System.Collections;
using UnityEngine;

namespace Linking
{
    public interface ICreator
    {
        GameObject GetGameObject(GameObject prefab, Transform parent = null);
        Transform GetCube();
        GameObject SimpleGO(string name = "Simple");
    }
}