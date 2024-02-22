using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AIEnemy
{
    public class Footsteps : MonoBehaviour
    {
        public AudioSource footsteps;
        public AudioClip footstepClip;

        public GameObject source;
        public float sRadius = 25;
        private void Start()
        {
            footsteps = GetComponent<AudioSource>();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("W");
                footsteps.PlayOneShot(footstepClip, 0.6f);
                NoiseDetect(source.transform.position, sRadius);
            }

        }
        void NoiseDetect(Vector3 center, float radius)
        {
            Collider[] hitCol = Physics.OverlapSphere(center, radius);
            for (int i = 0; i < hitCol.Length; i++)
            {
                Debug.Log("Heard" + hitCol[i].name);
            }
        }
    }
}


// Physics.OverlapSphere - give me all of the colliders that existing within a specific radius around a specific point