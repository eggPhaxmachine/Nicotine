using System.Collections;

public abstract class BackgroundEvent
{

    public bool active = true;

    public IEnumerator loop()
    {
        execute();

        if (!active)
        {
            yield break;
        }

        yield return null;
    }

    protected abstract void execute();

}