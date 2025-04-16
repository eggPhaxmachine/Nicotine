using System.Collections;

public abstract class Event
{
    protected bool finished;

    public void initialize()
    {
        finished = false;
        onStart();
    }

    protected abstract void onStart();

    public abstract IEnumerator execute();

    public abstract bool isFinished();
    
    public abstract void end();

}
