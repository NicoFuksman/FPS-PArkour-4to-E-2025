using UnityEngine;
using UnityEngine.SceneManagement;

public class MuertePorColision : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "Killer")
        {
            Debug.Log("Me morí");
            SceneManager.LoadScene("Parkour");
        }
    }
}
