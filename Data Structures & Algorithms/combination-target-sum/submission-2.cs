public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var ans = new List<List<int>>();

        void helper(List<int> curr, int i, int sum){
            if(sum==target){
                ans.Add(curr.ToList());
                return;
            }
            if(sum>target || i>=nums.Length) return;

            curr.Add(nums[i]);
            helper(curr, i, sum+nums[i]);
            curr.RemoveAt(curr.Count-1);
            helper(curr,i+1,sum);
        }
        helper([],0,0);
        return ans;
    }
}
