using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class Spawner : ISpawner
    {
        private ICreator creator;

        public Spawner(ICreator creator) => this.creator = creator;

        public MeshRenderer[] SpawnConnectable(GameObject prefab, float radius, int count)
        {
            MeshRenderer[] meshes = new MeshRenderer[count];
            float newRadius, angle;
            GameObject temp;
            for (int i = 0; i < count; i++)
            {
                newRadius = Random.Range(0.0f, radius);
                angle = Random.Range(0.0f, 2 * Mathf.PI);

                temp = creator.GetGameObject(prefab);
                temp.transform.position = new Vector3(GetXFromPolar(newRadius, angle), 0, GetYFromPolar(newRadius, angle));
                temp.name = prefab.name + '_' + i;
                meshes[i] = temp.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>();
            }

            return meshes;
        }

        private float GetXFromPolar(float r, float d) => r * Mathf.Cos(d);
        private float GetYFromPolar(float r, float d) => r * Mathf.Sin(d);
    }
}