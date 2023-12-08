namespace OneBackComboTrainingWeb.Domains.Tennis;

public class AllState : BaseState
{
    public AllState(TennisBox tennisBox) : base(tennisBox)
    {
    }

    public override string Score()
    {
        return $"{_scoreLookup[_tennisBox.GetSecondPlayerScore()]} all";
    }

    public override void NextState()
    {
        this.GoToLookupState();
    }
}