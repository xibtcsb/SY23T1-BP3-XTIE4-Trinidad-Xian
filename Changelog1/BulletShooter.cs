using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class BulletShooter : MonoBehaviour
    {
        [SerializeField]
        private GameObject bullet;

        public AudioManager.PlayerSFX sfxToPlay;

        void Start()
        {
        }

        void Update()
        {
            // Shoot
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AudioManager.instance.PlaySound(sfxToPlay);
                Instantiate(bullet, transform.position, Quaternion.identity);
            }
        }
    }
}
