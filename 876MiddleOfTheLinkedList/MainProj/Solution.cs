namespace _876MiddleOfTheLinkedListProj;

public static class Solution
{
    public static int MinEatingSpeed(int[] piles, int h) {
        int minK=1;
        int maxK=piles.Max();
        while(minK<maxK){
            int estimatedK=(maxK-minK)/2+minK;
            int hoursTaken=CalculateTime(piles,estimatedK);
            if(hoursTaken>h){
                minK=estimatedK+1;
            }else{
                maxK=estimatedK;
            }
        }
        return maxK;
    }
    private static int CalculateTime(int[] piles,int k){
        int h=0;
        for(int i=0;i<piles.Length;i++){
            h+=(int)Math.Ceiling((double)piles[i]/k);
        }
        return h;
    }
}