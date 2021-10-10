using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    [CreateAssetMenu(fileName = "SettingMaterials", menuName = "SO/SettingMaterials")]
    public class SettingMaterials : ScriptableObject
    {
        [SerializeField] private Material normalMaterial;
        [SerializeField] private Material optionMaterial;
        [SerializeField] private Material selectMaterial;
        public Material NormalMaterial => normalMaterial;
        public Material OptionMaterial => optionMaterial;
        public Material SelectMaterial => selectMaterial;
    }
}