using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class Coloring : IColoring
    {
        private MeshRenderer[] meshes;
        private SettingMaterials settingMaterials;

        public Coloring(MeshRenderer[] meshes, SettingMaterials settingMaterials)
        {
            this.meshes = meshes;
            this.settingMaterials = settingMaterials;
        }

        public void ColoringAllOption()
        {
            for (int i = 0; i < meshes.Length; i++)
                meshes[i].sharedMaterial = settingMaterials.OptionMaterial;
        }

        public void ColoringSelect(int val, bool select = true)
        {
            meshes[val].sharedMaterial = select ? settingMaterials.SelectMaterial : settingMaterials.OptionMaterial;
        }

        public void ColoringAllNormal()
        {
            for (int i = 0; i < meshes.Length; i++)
                meshes[i].sharedMaterial = settingMaterials.NormalMaterial;
        }
        public Transform GetTransform(int val) => meshes[val].transform;
    }
}