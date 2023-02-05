using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Project1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float force;
        Rigidbody rigidbody;
        DefaultInput �nput;

        bool IsForceUp;

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
            �nput = new DefaultInput();
        }

        private void Update()
        {
            if (�nput.IsForceUp)
            {
                IsForceUp = true;
            }
            else
            {
                IsForceUp = false;
            }
        }

        private void FixedUpdate()
        {
            if (IsForceUp)
            {
                rigidbody.AddForce(Vector3.up * Time.deltaTime * force);
            }
        }
    }
}
