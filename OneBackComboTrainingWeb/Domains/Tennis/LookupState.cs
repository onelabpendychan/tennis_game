namespace OneBackComboTrainingWeb.Domains.Tennis;

public class LookupState : BaseState
{
    public LookupState(TennisBox tennisBox) : base(tennisBox)
    {
    }

    public override string Score()
    {
        return $"{_scoreLookup[_tennisBox.GetFirstPlayerScore()]} {_scoreLookup[_tennisBox.GetSecondPlayerScore()]}";
    }

    public override void NextState()
    {
        if (_tennisBox.GetFirstPlayerScore() == _tennisBox.GetSecondPlayerScore())
        {
            if (_tennisBox.GetFirstPlayerScore() >= 3)
            {
                GotoDeuceState();
            }
            else
            {
                GotoAllState();
            }
            
        }
            
        else
            GoToLookupState();
    }

    private void GotoDeuceState()
    {
        throw new NotImplementedException();
    }
}