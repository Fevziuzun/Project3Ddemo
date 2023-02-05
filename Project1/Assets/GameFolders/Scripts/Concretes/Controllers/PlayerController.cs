using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Project1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float force;
        Rigidbody rigidbody;
        DefaultInput ýnput;

        bool IsForceUp;

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
            ýnput = new DefaultInput();
        }

        private void Update()
        {
            if (ýnput.IsForceUp)
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
