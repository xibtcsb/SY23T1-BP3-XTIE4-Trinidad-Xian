using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        private Vector2 cameraBounds;

        public Vector2 CameraBounds
        {
            get
            {
                return cameraBounds;
            }
        }

        void Awake()
        {
            cameraBounds = Camera.main.ScreenToWorldPoint(Vector2.zero);
            instance = this;
        }
    }
}
