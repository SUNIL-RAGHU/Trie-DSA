using System;
namespace trie
{
	public class Xor
	{
		class Trie
        {
			TrieNode root;

            public Trie()
            {
                root = new TrieNode();
            }

            public void insert(int num)
            {
                TrieNode curNode = root;

                for(int i = 31; i >= 0; i--)
                {
                    int bit = num >> i & 1;

                    if (curNode.nodes[bit] == null)
                    {
                        curNode.nodes[bit] = new TrieNode();
                    }

                    curNode = curNode.nodes[bit];
                }
            }


            public int getMax(int num)
            {

            }

        }


        class TrieNode
        {
            public TrieNode[] nodes;

            public TrieNode()
            {
                nodes = new TrieNode[2];
            }
        }
	}
}

