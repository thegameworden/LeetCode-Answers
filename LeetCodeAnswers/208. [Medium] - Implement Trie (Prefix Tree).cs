//This problem can be found at: https://leetcode.com/problems/implement-trie-prefix-tree

public class Trie {
    TrieNode root;
    public Trie() {
        root= new TrieNode();
    }
    
    public void Insert(string word)
    {
        TrieNode current = root;

        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
            {
                current.Children[c] = new TrieNode();
            }
            current = current.Children[c];
        }

        current.IsWord = true;
    }
    
    public bool Search(string word) {
        TrieNode node = root;
        for(int i=0;i<word.Length;i++){
            if(!node.Children.ContainsKey(word[i]))
            return false;

            node= node.Children[word[i]];
        }
        return node.IsWord;
    }
    
    public bool StartsWith(string prefix) {
         TrieNode node = root;
         for(int i=0;i<prefix.Length;i++){
                if(!node.Children.ContainsKey(prefix[i]))
            return false;
            node=node.Children[prefix[i]];
        }
        return true;
         
    }
}

public class TrieNode
{
    public bool IsWord;
    public Dictionary<char, TrieNode> Children;

    public TrieNode()
    {
        IsWord = false;
        Children = new Dictionary<char, TrieNode>();
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
