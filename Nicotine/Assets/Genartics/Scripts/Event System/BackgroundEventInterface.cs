using System.Collections;

public abstract class BackgroundEvent
{

    public bool active = true;

    public IEnumerator loop()
    {
        while (active)
        {

            execute();

            yield return null;

        }

        end();

    }

    public abstract void execute();

    protected virtual void end()
    {

    }

}