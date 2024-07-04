// Design Guru- problem -- Leetcode 1245. 


public class treeDiameterSolution
{

    private int treeDiameter = 0;

    public int findDiameter(TreeNode root)
    {
        treeDiameter = 0;
        calculateTreeHeight(root);
        return treeDiameter;
    }

    private int calculateTreeHeight(TreeNode node)
    {
       if(node == null) return 0;

        var ltht = calculateTreeHeight(node.left);
        var rtht = calculateTreeHeight(node.right);

        if (node.left != null && node.right != null)
        {
            var diameter = ltht+ rtht+ 1;
            treeDiameter = Math.Max(treeDiameter, diameter);
        }

            return Math.Max(ltht, rtht) + 1; ;
    }
}