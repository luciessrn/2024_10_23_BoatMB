using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Luciessrn { 
    public class BasicBoatMono : MonoBehaviour
{
[Range(-1, 1)]
[SerializeField] float m_percentHorizontalAxis;
[Range(-1, 1)]
[SerializeField] float m_percentVerticalAxis;

        public float boatSpeedVertical = 5f;
        public float RotationSpeedHorizontal = 5f;

        private void Update()
        {
            float VerticalMove = m_percentVerticalAxis * boatSpeedVertical * Time.deltaTime;
            transform.Translate(Vector3.forward * VerticalMove);

            float HorizontalTurn = m_percentHorizontalAxis * RotationSpeedHorizontal* Time.deltaTime;
            transform.Rotate(Vector3.up*HorizontalTurn);
        }

        public void SetHorizontal(float percent)
{
    percent = Mathf.Clamp(percent, -1f, 1f);
            m_percentHorizontalAxis = percent;
}
public void SetVertical(float percent)
{
    percent = Mathf.Clamp(percent, -1f, 1f);
            m_percentVerticalAxis = percent;
}




    [ContextMenu("Teleport Forward")]
    public void teleportForward()
    {
        transform.position += transform.forward * 1;
    }
}

}

