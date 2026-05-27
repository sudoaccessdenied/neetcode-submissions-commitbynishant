public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int l =0,count = 0;
        var r = people.Length-1;
        while(l<=r){
            var sum = people[l]+people[r];
            if(sum <=limit){
                l++;
                r--;
                
            }else{
                r--;
            }
            count++;
        }
        return count;
        
    }
}