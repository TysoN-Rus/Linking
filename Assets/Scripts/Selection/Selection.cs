using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class Selection : ISelection
    {
        private IMyInput myInput;
        private ISelectionMethod[] method;
        private IColoring coloring;
        private IShibari shibari;

        private Transform cursor;
        public Selection(IMyInput myInput, IColoring coloring, IShibari shibari, Transform cursor, ISelectionMethod[] method, string namePin)
        {
            this.myInput = myInput;
            this.method = method;
            this.coloring = coloring;
            this.shibari = shibari;

            this.cursor = cursor; 

            for (int i = 0; i < method.Length; i++)
            {
                method[i].Initialization(myInput, namePin);
                method[i].EvSelect += SelectPin;
                method[i].EvExitPin += ColoringOptionSelect;
                method[i].EvSpase += ColoringAllNormal;
                method[i].EvPosition += UpdaetLink;
            }
        }

        private int first = -1;
        private void SelectPin(int val)
        {
            if (first == -1)
            {
                coloring.ColoringAllOption();
                coloring.ColoringSelect(val);
                first = val;
                return;
            }

            if (first != val)
                SetLink(val);

            ColoringAllNormal();
        }

        private void SetLink(int second) => 
            shibari.CreateRope(coloring.GetTransform(first), coloring.GetTransform(second));

        private void UpdaetLink(Vector3 position)
        {
            cursor.position = position;
            shibari.UpdaetLink();
        }

        private void ColoringOptionSelect(int val)
        {
            if (val == first)
            {
                coloring.ColoringSelect(first, false);
                shibari.CreateTempRope(coloring.GetTransform(first), cursor);
            }
        }

        private void ColoringAllNormal()
        {
            shibari.ClearTempRope();
            first = -1;
            coloring.ColoringAllNormal();
        }
    }
}