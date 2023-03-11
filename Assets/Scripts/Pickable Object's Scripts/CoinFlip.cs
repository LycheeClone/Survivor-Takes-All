using UnityEngine;

namespace Pickable_Object_s_Scripts
{
    public class CoinFlip : MonoBehaviour
    {
        [SerializeField] private Vector3 rotateAngle;
        private void FixedUpdate()
        {
            CoinFlipper();
        }

        private void CoinFlipper()
        {
            transform.Rotate(rotateAngle, Space.World);
        }
    }
}