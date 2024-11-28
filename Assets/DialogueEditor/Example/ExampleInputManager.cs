using DialogueEditor.Assets.Scripts.UI;
using UnityEngine;

namespace DialogueEditor.Example
{
    public class ExampleInputManager : MonoBehaviour
    {
        public KeyCode m_UpKey;
        public KeyCode m_DownKey;
        public KeyCode m_SelectKey;

        private void Update()
        {
            if (ConversationManager.Instance != null)
            {
                UpdateConversationInput();
            }
        }

        private void UpdateConversationInput()
        {
            if (ConversationManager.Instance.IsConversationActive)
            {
                if (Input.GetKeyDown(m_UpKey))
                    ConversationManager.Instance.SelectPreviousOption();
                else if (Input.GetKeyDown(m_DownKey))
                    ConversationManager.Instance.SelectNextOption();
                else if (Input.GetKeyDown(m_SelectKey))
                    ConversationManager.Instance.PressSelectedOption();
            }
        }
    }
}
