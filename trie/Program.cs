//class Trie
//{

//    TrieNode root;
//    public Trie()
//    {
//        root = new TrieNode();
//    }
//    public void Insert(string word)
//    {
//        var n = word.Length;
//        TrieNode curNode = root;
//        for (int i = 0; i < n; i++)
//        {
//            var index = word[i] - 'a';
//            if (curNode.nodes[index] == null)
//            {
//                curNode.nodes[index] = new TrieNode();
//            }
//            curNode = curNode.nodes[index];


//        }
//        curNode.isWord = true;
//    }
//    public bool Search(string word)
//    {
//        var n = word.Length;
//        TrieNode curNode = root;
//        for (int i = 0; i < n; i++)
//        {
//            var index = word[i] - 'a';
//            if (curNode.nodes[index] == null)
//            {
//                return false;
//            }
//            curNode = curNode.nodes[index];
//        }
//        return curNode.isWord;
//    }
//    public bool StartsWith(string prefix)
//    {
//        var n = prefix.Length;
//        TrieNode curNode = root;
//        for (int i = 0; i < n; i++)
//        {
//            var index = prefix[i] - 'a';
//            if (curNode.nodes[index] == null)
//            {
//                return false;
//            }
//            curNode = curNode.nodes[index];
//        }
//        return true;
//    }
//}

//class TrieNode
//{
//    public TrieNode[] nodes;
//    public bool isWord;


//    public TrieNode()
//    {
//        nodes = new TrieNode[26];
//        isWord = false;
//    }
//}


//class main
//{
//    public static void Main(String[] args)
//    {


//        Trie trie = new Trie();

//        string[] value = { "the", "a", "there", "answer",
//                        "any", "by", "bye", "their"};

//        String[] output = { "Not present in trie", "Present in trie" };

//        int i;
//        for (i = 0; i < value.Length; i++)
//            trie.Insert(value[i]);

//        if (trie.Search("the") == true)
//            Console.WriteLine("the --- " + output[1]);
//        else Console.WriteLine("the --- " + output[0]);

//        if (trie.Search("these") == true)
//            Console.WriteLine("these --- " + output[1]);
//        else Console.WriteLine("these --- " + output[0]);

//        if (trie.Search("their") == true)
//            Console.WriteLine("their --- " + output[1]);
//        else Console.WriteLine("their --- " + output[0]);

//        if (trie.StartsWith("thaw") == true)
//            Console.WriteLine("thaw --- " + output[1]);
//        else Console.WriteLine("thaw --- " + output[0]);
//    }
//}





