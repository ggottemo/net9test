namespace dotnet9test;

public class Lockingkeyword {
    Lock myLock = new Lock();
    void CriticalSection()
    {
        using (myLock.EnterScope())
        {
            // Perform thread-safe operations
        }
    }

    public void SafeIncrement(ref int counter)
    {

        using (myLock.EnterScope())
        {

            counter++;
        }
    }

}