using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Linking
{
    public class Rope
    {
        private Transform ropeTransform;
        private Transform pinOne, pinTwo;

        private IMovingConnectable moving;

        public Rope(Transform ropeTransform, Transform pinOne, Transform pinTwo, IMovingConnectable moving)
        {
            this.ropeTransform = ropeTransform;
            this.pinOne = pinOne;
            this.pinTwo = pinTwo;
            this.moving = moving;

            this.moving.EvMovingPin += Cheking;
            Update();
        }

        private void Cheking(Transform pin)
        {
            if (pin == pinOne.parent || pin == pinTwo.parent)
                Update();
        }

        public void Update()
        {
            ropeTransform.position = pinOne.position + (pinTwo.position - pinOne.position) / 2;
            ropeTransform.localScale = new Vector3(0.1f, Vector3.Distance(pinTwo.position, pinOne.position), 0.1f);
            ropeTransform.up = pinTwo.position - pinOne.position;
        }

        public void Destroy()
        {
            moving.EvMovingPin -= Cheking;
            GameObject.Destroy(ropeTransform.gameObject);
        }
    }
}