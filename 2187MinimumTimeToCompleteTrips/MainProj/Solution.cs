namespace _2187MinimumTimeToCompleteTripsProj;
public static class Solution
{
    public static long MinimumTime(int[] time, int totalTrips)
    {
        if(time.Length == 1) return ((long)time[0] * totalTrips);

        long startTime = time.Min();
        long result = ((long)startTime * totalTrips);
        long endTime = result;

        while(startTime <= endTime)
        {
            long timeTaken = startTime + (endTime - startTime + 1) / 2;

            if(time.Sum(x => timeTaken / x) >= totalTrips)
            {
                result = Math.Min(result, timeTaken);
                endTime = timeTaken -1;
            }
            else
                startTime = timeTaken + 1;
        }

        return result;
    }
}