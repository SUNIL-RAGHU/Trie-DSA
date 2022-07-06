
namespace trie
{

    public class Solution
    {
        public static void Main(String[] args)
        {

            Trie trie = new Trie();

            int b = trie.countDistinctSubStrings("abab");

            Console.WriteLine("THE VALUE OF DISTICT ELLEMTNS:"+b);

        }


        class Trie
        {

            TrieNode root;
            public Trie()
            {
                root = new TrieNode();
            }
            public int countDistinctSubStrings(string word)
            {
                var n = word.Length;
                int a = 0;
                for (int i = 0; i < n; i++)
                {
                    TrieNode curNode = root;
                    for (int j = i; j < n; j++)
                    {
                        var index = word[j] - 'a';
                        if (curNode.nodes[index] == null)
                        {
                            curNode.nodes[index] = new TrieNode();
                            a++;
                        }
                        curNode = curNode.nodes[index];


                    }
                }

                return 1 + a;

            }


        }
        class TrieNode
        {
            public TrieNode[] nodes;



            public TrieNode()
            {
                nodes = new TrieNode[26];

            }
        }
    }
}


