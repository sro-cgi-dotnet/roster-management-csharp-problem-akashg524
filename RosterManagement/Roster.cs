using System;
using System.Collections.Generic;
using System.Linq;

namespace RosterManagement 
{
    public class CodeSchool 
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool () 
        {
            _roster = new Dictionary<int, List<String>> ();
        }

        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add (string cadet, int wave) {
            if (_roster.ContainsKey (wave)) 
            {
                _roster[wave].Add(cadet);
            } else {
                _roster[wave] = new List<string> { cadet };
            }
        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade (int wave) 
        {
            var list = new List<string> ();
            if (!_roster.ContainsKey (wave)) 
            {
                return list;
            } else {
                list = _roster[wave];
                list.Sort ();
                return list;
            }
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name in sorted order</returns>
        public List<string> Roster () 
        {
            var d=new SortedDictionary<int,List<string>>(_roster);
            var cadets = new List<string> ();
            foreach(KeyValuePair<int,List<string>> key_val in d)
            {
                key_val.Value.Sort();
                cadets.AddRange(key_val.Value);
            }
            return cadets;
        }
    }
}