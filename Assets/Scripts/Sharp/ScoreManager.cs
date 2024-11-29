using UnityEngine;

namespace Sharp
{
    public class ScoreManager : MonoBehaviour
    {
        public int FriendlinessScores { get; private set; }
        public int Money { get; private set; }

        public void AddScoreTravelling(int count)
        {
            FriendlinessScores += count;
        }

        public void AddScoreMoney(int count)
        {
            Money += count;
        }

        public void AddScoreFriendliness(int count)
        {
            FriendlinessScores += count;
        }
    }
}