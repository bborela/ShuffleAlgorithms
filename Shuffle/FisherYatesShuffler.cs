using System;

namespace Shuffle
{
    public class FisherYatesShuffler : IShuffler
    {
        private int[] _arrayToShuffle;
        private Random _random;
        private int _currentPosition;

        public int[] Shuffle(int[] arrayToShuffle)
        {
            _random = new Random();
            _arrayToShuffle = arrayToShuffle;

            for (_currentPosition = _arrayToShuffle.Length - 1; _currentPosition > 0; _currentPosition--)
                RollAndSwap();

            return _arrayToShuffle;
        }

        private void RollAndSwap()
        {
            var roll = Roll();
            var j = _arrayToShuffle[_currentPosition];
            _arrayToShuffle[_currentPosition] = _arrayToShuffle[roll];
            _arrayToShuffle[roll] = j;
        }

        private int Roll()
        {
            return _random.Next(_currentPosition + 1);
        }
    }
}
