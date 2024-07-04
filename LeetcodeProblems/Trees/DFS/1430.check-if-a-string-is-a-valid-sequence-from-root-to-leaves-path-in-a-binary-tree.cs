public class BSTSolution
{
    public bool IsValidSequence(TreeNode root, int[] arr)
    {
        if (root == null)
            return arr.Length == 0;
        return callTreeResursively(root, arr, 0);
    }
    public bool callTreeResursively(TreeNode root, int[] arr, int index)
    {
        if (root == null)
        {
            return false;
        }
        if (index > arr.Length - 1)
        {
            return false;
        }

        if (root.right == null && root.left == null &&  index == arr.Length-1 && root.val == arr[index])
        {
            return true;
        }

       if(root.val == arr[index])
        {
            return callTreeResursively(root.left, arr, index + 1) || callTreeResursively(root.right, arr, index + 1);
        }
        else
        {
            return false;
        }
            
    }
}