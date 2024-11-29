using UnityEngine;
using UnityEngine.UI;

namespace Sharp
{
    public class Thought : MonoBehaviour
    {
        [SerializeField] private Sprite spriteThought;
        [SerializeField] private Sprite spriteBasicSpeech;

        private Image _image;

        private void Start()
        {
            _image = GetComponent<Image>();
        }

        public void SetThought()
        {
            _image.sprite = spriteThought;
        }

        public void SetBasicSpeech()
        {
            _image.sprite = spriteBasicSpeech;
        }
    }
}