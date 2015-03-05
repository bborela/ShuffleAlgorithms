using System;

namespace Shuffle
{
    class DurstenfeldShuffler : IShuffler
    {
        private Random _random;
        private int _currentPosition;
        private int[] _shuffledArray;
        private int[] _arrayToShuffle;

        public int[] Shuffle(int[] arrayToShuffle)
        {
            _arrayToShuffle = arrayToShuffle;
            _random = new Random();
            _shuffledArray = new int[_arrayToShuffle.Length];

            for (_currentPosition = 0; _currentPosition < _shuffledArray.Length; _currentPosition++)
                RollAndSwap();

            return _shuffledArray;
        }

        private void RollAndSwap()
        {
            var roll = Roll();
            _shuffledArray[_currentPosition] = _shuffledArray[roll];
            _shuffledArray[roll] = _arrayToShuffle[_currentPosition];
        }
        
        private int Roll()
        {
            return _random.Next(_currentPosition + 1);
        }
    }
}