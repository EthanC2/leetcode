 //Useful video: https://www.youtube.com/watch?v=6ZnyEApgFYg
class Solution 
{
  public:
      std::vector<std::vector<int>> levelOrder(TreeNode* root) 
      {
          std::vector<std::vector<int>> result;
          std::queue<TreeNode*> nodes;

          if (root != nullptr) 
              nodes.push(root);

          while (not nodes.empty()) 
          {
              std::size_t size = nodes.size();
              result.push_back({});    //append empty list

              for (std::size_t i = 0; i < size; ++i)
              {		
                  TreeNode* curr = nodes.front();
                  nodes.pop();
                  result.back().push_back(curr->val);

                  if (curr->left != nullptr)  nodes.push(curr->left);
                  if (curr->right != nullptr) nodes.push(curr->right);
              }
          }

          return result;
      }
};
