namespace OneBackComboTrainingWeb.Domains.Tennis;

public class TennisBox
{
    private BaseState _currentState;
    private int _firstPlayerScore;
    private int _secondPlayerScore;

    public TennisBox()
    {
        _currentState = new AllState(this);
    }

    public void FirstPlayerGoal()
    {
        _firstPlayerScore++;
        _currentState.NextState();
    }

    public void ChangeState(BaseState state)
    {
        _currentState = state;
    }

    public string Score()
    {
        return _currentState.Score();
    }

    public int GetFirstPlayerScore()
    {
        return _firstPlayerScore;
    }

    public void SecondPlayerGoal()
    {
        _secondPlayerScore++;
        _currentState.NextState();
    }

    public int GetSecondPlayerScore()
    {
        return _secondPlayerScore;
    }
}