  using System.Collections;

public abstract class Event
{
    public bool finished;

    public bool isFinished()
    {
        return finished; 
    }

    public void initialize()
    {
        finished = false;
        onStart();
    }

    protected virtual void onStart()
    {

    }

    public abstract IEnumerator execute();

    //public abstract bool isFinished();

    public virtual void end()
    {

    }

}
