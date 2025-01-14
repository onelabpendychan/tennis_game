﻿namespace OneBackComboTrainingWeb
{
    public class TennisGame
    {
        private string _firstPlayerName;
        private string _secondPlayerName;
        private string _score;
        private Dictionary<int, string> _scoreMap;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _secondPlayerName = secondPlayerName;
            _firstPlayerName = firstPlayerName;
            _scoreMap = new Dictionary<int, string>
            {
                {0, "love"},
                {1, "fifteen"},
                {2, "thirty"},
                {3, "forty"}
            };
            _score = CalculatorScore();
        }

        public string Score
        {
            get => _score;
        }

        private int _firstPlayerScore;

        private int _secondPlayerScore;

        public void AddFirstPlayerScore()
        {
            _firstPlayerScore++;
            _score = CalculatorScore();
        }

        public void AddSecondPlayerScore()
        {
            _secondPlayerScore++;
            _score = CalculatorScore();
        }

        private string CalculatorScore()
        {
            if (!_scoreMap.TryGetValue(_firstPlayerScore, out var firstPlayerScore))
            {
                //>=4
            }

            if (!_scoreMap.TryGetValue(_secondPlayerScore, out var secondPlayerScore))
            {
                //>=4
            }

            if (_firstPlayerScore == _secondPlayerScore)
            {
                if (_firstPlayerScore < 3)
                {
                    return $"{firstPlayerScore} all";
                }

                return "deuce";
            }

            if (_firstPlayerScore < 3 && _secondPlayerScore < 3)
            {
                return $"{firstPlayerScore} {secondPlayerScore}";
            }

            if (Math.Abs(_firstPlayerScore-_secondPlayerScore) >= 2)
            {
                if (_firstPlayerScore > _secondPlayerScore)
                    return $"{_firstPlayerName} win";
                return $"{_secondPlayerName} win";
            }

            if (_firstPlayerScore > _secondPlayerScore)
                return $"{_firstPlayerName} adv";
            return $"{_secondPlayerName} adv";
        }
    }
}
