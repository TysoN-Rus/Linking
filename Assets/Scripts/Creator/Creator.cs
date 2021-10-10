using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class Creator : MonoBehaviour, ICreator
    {
        public GameObject GetGameObject(GameObject prefab, Transform parent = null) => Instantiate(prefab, parent ? parent : transform);

        public Transform GetCube()
        {
            Transform temp = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
            temp.parent = transform;
            return temp;
        }
        public GameObject SimpleGO(string name = "Simple")
        {
            GameObject temp = new GameObject(name);
            temp.transform.parent = transform;
            return temp;
        }
    }
}