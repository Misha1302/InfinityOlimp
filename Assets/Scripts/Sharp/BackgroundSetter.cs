using UnityEngine;
using UnityEngine.UI;

namespace Sharp
{
    public class BackgroundSetter : MonoBehaviour
    {
        private Image _image;

        private void Start()
        {
            _image = GetComponent<Image>();
        }

        public void SetBackgroundSprite(Sprite sprite)
        {
            _image.sprite = sprite;
        }
    }
}