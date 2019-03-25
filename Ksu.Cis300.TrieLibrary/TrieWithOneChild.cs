/* TrieWithOneChild.cs
 * Name: Kaylynn Diaz-Schott
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    class TrieWithOneChild : ITrie
    {
        /// <summary>
        /// Handles whether an item is an empty string or not
        /// </summary>
        private bool _containsEmpty = false;
        /// <summary>
        /// Handles the child
        /// </summary>
        private ITrie _onlyChild;

        /// <summary>
        /// Takes care of the child's label
        /// </summary>
        private char _childLabel;

        /// <summary>
        /// Constructor for Trie with One Child
        /// </summary>
        /// <param name="s">Incoming String</param>
        public TrieWithOneChild(string s, bool containsEmptyStr)
        {
            if (s == "" || s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }

            _containsEmpty = containsEmptyStr;
            _childLabel = s[0];

            _onlyChild = new TrieWithNoChildren().Add(s.Substring(1));

        }

        /// <summary>
        /// Adds value with interface
        /// </summary>
        /// <param name="s">Incoming string</param>
        /// <returns>Updated trie</returns>
        ITrie Add(string s)
        {
            if (s == "")
            {
                _containsEmpty = true;
                return this;
            }
            else if (s[0] == _childLabel)
            {
                _onlyChild = _onlyChild.Add(s.Substring(1));
                return this;
            }
            else
            {
                return new TrieWithManyChildren(s, _containsEmpty, _childLabel, _onlyChild);
            }
        }

        /// <summary>
        /// Determines whether Trie contains value with interface
        /// </summary>
        /// <param name="s">Incoming string</param>
        /// <returns>bool value based on whether value is found or not in the trie</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _containsEmpty;
            }
            else if (s[0] == _childLabel)
            {
                return _onlyChild.Contains(s.Substring(1));

            }
            else
            {
                return false;
            }

        }


      
    }
}
}
