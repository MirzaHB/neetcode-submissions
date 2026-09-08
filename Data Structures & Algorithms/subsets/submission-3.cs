public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var ans = new List<List<int>>();

        void helper(List<int> curr, int i){
            if(i==nums.Length){
                ans.Add(curr.ToList());
                return;
            }
            curr.Add(nums[i]);
            helper(curr,i+1);
            curr.RemoveAt(curr.Count-1);
            helper(curr,i+1);
        }
        helper([],0);
        return ans;
    }
}
