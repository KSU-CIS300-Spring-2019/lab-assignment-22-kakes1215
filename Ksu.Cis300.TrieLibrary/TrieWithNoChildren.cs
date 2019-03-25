/* TrieWithNoChildren.cs
 * Name: Kaylynn Diaz-Schott
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithNoChildren : ITrie
    {

        /// <summary>ITrie
        /// Determines whether the value contains a empty string or not
        /// </summary>
        private bool _containsEmpty = false;

        /// <summary>
        /// Adds new trie
        /// </summary>
        /// <param name="s">Incoming String</param>
        /// <returns>Updated Trie</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _containsEmpty = true;
                return this;

            }
            else
            {
                return new TrieWithOneChild(s, _containsEmpty);
            }

        }

        /// <summary>
        /// Determines if string is in the Trie or not
        /// </summary>
        /// <param name="s">Incoming String</param>
        /// <returns>Bool value based on whether it contains the string or not</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _containsEmpty;
            }
            else
            {
                return false;
            }

        }

    }
}
