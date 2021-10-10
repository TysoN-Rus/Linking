using UnityEngine;

namespace Linking
{
    public interface ISpawner
    {
        MeshRenderer[] SpawnConnectable(GameObject prefab, float radius, int count);
    }
}