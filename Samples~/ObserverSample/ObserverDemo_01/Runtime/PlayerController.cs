using UnityEngine;

namespace ObserverPackage.Samples.Runtime.ObserverDemo_01
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 5f;

        private void Update() => Move();

        private void Move()
        {
            float moveX = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
            float moveZ = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

            transform.Translate(new Vector3(moveX, 0, moveZ));
        }
    }
}