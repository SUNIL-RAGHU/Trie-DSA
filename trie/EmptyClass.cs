//using System;
//namespace trie
//{
//    public class Trie
//    {
//        TrieNode root;
//        public Trie()
//        {
//            root = new TrieNode();
//        }

//        public void Insert(string word)
//        {
//            int n = word.Length;
//            TrieNode curNode = root;
//            for (int i = 0; i < n; i++)
//            {
//                var index = word[i] - 'a';
//                if (curNode.nodes[index] == null)
//                {
//                    curNode.nodes[index] = new TrieNode();
//                }

//                curNode = curNode.nodes[index];

//                {
//                    curNode.cutEndWith++;

//                }
//            }
//            curNode.cutprefix++;
//        }




//        public int countWordsEqualTo(String word)
//        {
//            var n = word.Length;
//            TrieNode curNode = root;
//            for (int i = 0; i < n; i++)
//            {
//                var index = word[i] - 'a';
//                if (curNode.nodes[index] != null)
//                {
//                    curNode = curNode.nodes[index];

//                }
//                else
//                {
//                    return 0;
//                }
//            }
//            return curNode.cutEndWith;
//        }

//        public int countWordsStartingwith(String word)
//        {
//            var n = word.Length;
//            TrieNode curNode = root;
//            for (int i = 0; i < n; i++)
//            {
//                var index = word[i] - 'a';
//                if (curNode.nodes[index] != null)
//                {
//                    curNode = curNode.nodes[index];

//                }
//                else
//                {
//                    return 0;
//                }
//            }
//            return curNode.cutEndWith;
//        }

//        public void erase(String word)
//        {
//            var n = word.Length;
//            TrieNode curNode = root;
//            for (int i = 0; i < n; i++)
//            {
//                var index = word[i] - 'a';
//                if (curNode.nodes[index] != null)
//                {
//                    curNode = curNode.nodes[index];
//                    curNode.cutprefix--;

//                }
//                else
//                {
//                    return;
//                }



//            }

//            curNode.cutEndWith--;
//        }
//    }


//    class TrieNode
//    {
//        public TrieNode[] nodes;
//        public int cutEndWith;
//        public int cutprefix;


//        public TrieNode()
//        {
//            nodes = new TrieNode[26];
//            cutEndWith = 0;
//            cutprefix = 0;
//        }
//    }


//    class m
//    {
//        public static void Main(String[] args)
//        {
//            Trie T = new Trie();
//            T.Insert("apple");
//            T.Insert("apple");
//            T.Insert("apps");
//            T.Insert("apps");
//            String word1 = "apps";

//            Console.WriteLine("Count Words Equal to " + word1 + " " + T.countWordsEqualTo(word1));
//            String word2 = "abc";
//            Console.WriteLine("Count Words Equal to " + word2 + " " + T.countWordsEqualTo(word2));
//            String word3 = "ap";
//            Console.WriteLine("Count Words Starting With " + word3 + " " + T.countWordsStartingwith(word3));
//            String word4 = "appl";
//            Console.WriteLine("Count Words Starting With " + word4 + " " + T.countWordsStartingwith(word4));
//            T.erase(word1);
//            Console.WriteLine("Count Words equal to " + word1 + " " + T.countWordsEqualTo(word1));

//        }
//    }
//}

