public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] tmp = new int[nums1.Length];
        int i1=0;
        int i2=0;

        for(int i=0;i<tmp.Length;i++){
            if(i1<m && i2<n){
                if(nums1[i1]<=nums2[i2]){
                    tmp[i] = nums1[i1];
                    i1++;
                    continue;
                }else{
                    tmp[i] = nums2[i2];
                    i2++;
                    continue;
                }
            }
            else if(i1<m){
                tmp[i] = nums1[i1];
                i1++;
                continue;
            }else{
                tmp[i] = nums2[i2];
                i2++;
                continue;
            }
        }
        int k=0;
        foreach(int num in tmp) {nums1[k] = num; k++;}
    }
}