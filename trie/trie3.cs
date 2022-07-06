//using System;
//namespace trie
//{


//    class Trie
//    {

//        TrieNode root;
//        public Trie()
//        {
//            root = new TrieNode();
//        }
//        public void Insert(string word)
//        {
//            var n = word.Length;
//            TrieNode curNode = root;
//            for (int i = 0; i < n; i++)
//            {
//                var index = word[i] - 'a';
//                if (curNode.nodes[index] == null)
//                {
//                    curNode.nodes[index] = new TrieNode();
//                }
//                curNode = curNode.nodes[index];


//            }
//            curNode.isWord = true;
//        }


//        public bool checkIfAllPrefixExists(String word)
//        {
//            var n = word.Length;
//            bool isword = true;
//            TrieNode curNode = root;

//            for (int i = 0; i < word.Length && isword; i++)
//            {
//                var index = word[i] - 'a';
//                if (curNode.nodes[index] != null)
//                {
//                    curNode = curNode.nodes[index];
//                    isword = isword & curNode.isWord;
//                }

//                else
//                {
//                    return false;
//                }
//            }
//            return isword;
//        }


      
//    }
//    class TrieNode
//    {
//        public TrieNode[] nodes;
//        public bool isWord;


//        public TrieNode()
//        {
//            nodes = new TrieNode[26];
//            isWord = false;
//        }
//    }


//    class main
//    {
//        public static void Main(String[] args)
//        {

//            string[] value = new string[4] {"ab","abc","a","bp"};

//            int a = value.Length;

//            string b = completeString(a, value);

//            Console.WriteLine(b);

            
//        }

//        public static String completeString(int n, String[] a)
//        {
//            Trie obj = new Trie();
//            for (int i = 0; i < n; i++)
//            {
//                obj.Insert(a[i]);
//            }
//            String longest = "";
//            for (int i = 0; i < n; i++)
//            {
//                if (obj.checkIfAllPrefixExists(a[i]))
//                {
//                    if (a[i].Length > longest.Length)
//                    {
//                        longest = a[i];
//                    }

//                    else if (a[i].Length == longest.Length && a[i].CompareTo(longest) < 0)
//                    {
//                        longest = a[i];
//                    }
//                }
//            }
//            if (longest == "") return "None";
//            return longest;

//        }





          
//        }
//    }




