/* ITrie.cs
 * Name: Kaylynn Diaz-Schott
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    /// <summary>
    /// Trie Interface
    /// </summary>
    public interface ITrie
    {
        /// <summary>
        /// Holds bool value based on whether it contains a string
        /// </summary>
        /// <param name="s">The string the Trie will try to find</param>
        /// <returns>Whether the string is in the Trie or not</returns>
        bool Contains(string s);

        /// <summary>
        /// Adds the string to the trie
        /// </summary>
        /// <param name="s">The string that will be added to the Trie</param>
        /// <returns>The updated Trie</returns>
        ITrie Add(string s);
       
    }
}
