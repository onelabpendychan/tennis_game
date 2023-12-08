namespace OneBackComboTrainingWeb.Domains.Tennis;

public abstract class BaseState
{
    protected TennisBox _tennisBox;

    protected readonly Dictionary<int, string> _scoreLookup = new()
    {
        {0,"love"},
        {1,"fifteen"},
        {2,"thirty"},
        {3,"forty"}
    };

    protected BaseState(TennisBox tennisBox)
    {
        _tennisBox = tennisBox;
    }

    public abstract string Score();

    public void GoToLookupState()
    {
        _tennisBox.ChangeState(new LookupState(_tennisBox));
    }

    public abstract void NextState();

    public void GotoAllState()
    {
        _tennisBox.ChangeState(new AllState(_tennisBox));
    }
}