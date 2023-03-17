using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
    /// <summary>
    /// A class for solving Leetcode problem 208. Implement Trie (Prefix Tree)
    /// </summary>
    /// A trie (pronounced as "try") or prefix tree is a tree data structure used to efficiently store and retrieve keys in a dataset of strings.
    /// There are various applications of this data structure, such as autocomplete and spellchecker.
    /// 
    /// Implement the Trie class:
    /// Trie() Initializes the trie object.
    /// void insert(String word) Inserts the string word into the trie.
    /// boolean search(String word) Returns true if the string word is in the trie (i.e., was inserted before), and false otherwise.
    /// boolean startsWith(String prefix) Returns true if there is a previously inserted string word that has the prefix prefix, and false otherwise.
    /// 
    /// Example 1:
    /// Input ["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
    /// [[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
    /// 
    /// Output
    /// [null, null, true, false, true, null, true]
    /// 
    /// Explanation
    /// Trie trie = new Trie();
    /// trie.insert("apple");
    /// trie.search("apple");   // return True
    /// trie.search("app");     // return False
    /// trie.startsWith("app"); // return True
    /// trie.insert("app");
    /// trie.search("app");     // return True
    /// 
    /// Constraints:
    /// 
    /// 1 <= word.length, prefix.length <= 2000
    /// word and prefix consist only of lowercase English letters.
    /// At most 3 * 104 calls in total will be made to insert, search, and startsWith.
    public class PrefixTree
    {
        private List<string> _words;

        public PrefixTree()
        {
            _words = new List<string>();
        }

        /// <summary>
        /// Inserts the given word into the Trie.
        /// </summary>
        /// <param name="word"></param>
        public void Insert(string word)
        {
            _words.Add(word);
        }

        /// <summary>
        /// Returns true if the given word is in the Trie already.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Search(string word)
        {
            if (_words.Contains(word))
                return true;

            return false;
        }

        /// <summary>
        /// Returns true if there exists a word in the Trie which has the given prefix.
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public bool StartsWith(string prefix)
        {
            foreach (string word in _words)
            {
                if (word.StartsWith(prefix))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
