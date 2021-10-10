using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

namespace Linking
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] private Container container;
        [SerializeField] private Creator creator;

        private IMyInput myInput;
        private IMyInput myInputMask;
        private ISpawner spawner;
        private ISelection selection;
        private IColoring coloring;
        private IMovingConnectable movingConnectable;
        private IShibari shibari;


        private void Awake()
        {
            Random.InitState((int)DateTime.Now.Ticks);

            myInput = new MyInput(Camera.main, this, container.LayerMaskDefauilt);
            myInputMask = new MyInput(Camera.main, this, container.LayerMaskRope);

            spawner = new Spawner(creator);
            coloring = new Coloring(
                spawner.SpawnConnectable(container.PrefabConnectable, container.RadiusSpawn, container.CountConnectable),
                container.SettingMaterials
                );

            movingConnectable = new MovingConnectable(myInput, container.NameBottom);

            SelectionMethod[] selectionMethods = new SelectionMethod[]
            {
                new SelectionMethodCliked(),
                new SelectionMethodDrag()
            };

            shibari = new Shibari(creator, movingConnectable, myInputMask);
            selection = new Selection(myInput, coloring, shibari, creator.SimpleGO("Cursor").transform, selectionMethods, container.NamePin);
        }
    }
}