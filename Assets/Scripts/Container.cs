using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class Container : MonoBehaviour
    {
        [SerializeField] private float radiusSpawn;
        [SerializeField] private int countConnectable;
        [SerializeField] private GameObject prefabConnectable;

        [SerializeField] private string namePin;
        [SerializeField] private string nameBottom;

        [SerializeField] private SettingMaterials settingMaterials;

        [SerializeField] private LayerMask layerMaskDefauilt;
        [SerializeField] private LayerMask layerMaskRope;

        public float RadiusSpawn => radiusSpawn;
        public int CountConnectable => countConnectable;
        public GameObject PrefabConnectable => prefabConnectable;
        public SettingMaterials SettingMaterials => settingMaterials;
        public string NamePin => namePin;
        public string NameBottom => nameBottom;
        public LayerMask LayerMaskRope => layerMaskRope;
        public LayerMask LayerMaskDefauilt => layerMaskDefauilt;
    }
}