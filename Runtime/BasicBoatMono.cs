using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Luciessrn { 
    public class BasicBoatMono : MonoBehaviour
{
    [ContextMenu("Teleport Forward")]
    public void teleportForward()
    {
        transform.position += transform.forward * 1;
    }
}

}

