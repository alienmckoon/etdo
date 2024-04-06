// Assuming delayBetweenAccountsInS is defined earlier in the code.
// This method introduces a delay asynchronously, allowing other tasks to run during the wait.
public async Task IntroduceDelayAsync(int delayInSeconds)
{
    // Convert seconds to milliseconds for the appropriate delay duration.
    int delayInMilliseconds = delayInSeconds * 1000;

    // Await the delay without blocking the thread, using ConfigureAwait to avoid capturing the synchronization context.
    await Task.Delay(delayInMilliseconds).ConfigureAwait(false);
}

// Usage of the method elsewhere in the code.
await IntroduceDelayAsync(delayBetweenAccountsInS);
