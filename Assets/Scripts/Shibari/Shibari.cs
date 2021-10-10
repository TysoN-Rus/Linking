using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class Shibari : IShibari
    {
        private ICreator creator;
        private IMyInput myInputMask;
        private IMovingConnectable moving;

        private Rope rope;

        private int layerObj;
        private Dictionary<int, Rope> ropes;
        private int ID;

        private readonly string nameRope = "Rope";
        public Shibari(ICreator creator, IMovingConnectable moving, IMyInput myInputMask)
        {
            this.creator = creator;
            this.moving = moving;
            this.myInputMask = myInputMask;

            layerObj = LayerMask.NameToLayer(nameRope);
            ropes = new Dictionary<int, Rope>();
            myInputMask.EvDown += Down;
            myInputMask.EvUp += Delete;
        }

        private void Down(RaycastHit hit)
        {
            if (hit.transform != null && hit.transform.name.Split('_')[0] == nameRope)
                selectDelete = hit.transform;
        }

        private Transform selectDelete;
        private void Delete(RaycastHit hit)
        {
            if (selectDelete != null && selectDelete == hit.transform)
            {
                int val = MyMethods.GetWhatID(hit.transform);
                ropes[val].Destroy();
                ropes.Remove(val);
                selectDelete = null;
            }
        }

        public void CreateRope(Transform pinOne, Transform pinTwo)
        {
            Transform temp = creator.GetCube();
            temp.gameObject.layer = layerObj;
            temp.name = nameRope + '_' + ID;
            ropes.Add(ID, new Rope(temp, pinOne, pinTwo, moving));
            ID++;
        }
        public void UpdaetLink()
        {
            if (rope != null)
                rope.Update();
        }
        public void CreateTempRope(Transform pinOne, Transform pinTwo)
        {
            Transform ropeTransform = creator.GetCube();
            ropeTransform.gameObject.layer = layerObj;
            rope = new Rope(ropeTransform, pinOne, pinTwo, moving);
        }

        public void ClearTempRope()
        {
            if (rope != null)
            {
                rope.Destroy();
                rope = null;
            }
        }
    }
}