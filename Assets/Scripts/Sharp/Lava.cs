using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sharp
{
    public class Lava : MonoBehaviour
    {
        private void OnCollisionEnter2D()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}