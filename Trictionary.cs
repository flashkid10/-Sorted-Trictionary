using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AniLyst_5._0
{
    public class Trictionary<Key, Value, Control>
    {
        public Trictionary()
        {
        }

        public Trictionary(Trictionary<Key, Value, Control> Trictionary)
        {
            foreach (KeyValueTriple<Key, Value, Control> U in (Trictionary.MemberwiseClone() as Trictionary<Key, Value, Control>)) Add(U);
        }

        #region GetEnumerator

        public int Count { get { return DataTrack.Count(); } }
        public List<Key> Keys { get { return DataTrack.Keys.ToList(); } }
        private Dictionary<Key, KeyValueTriple<Key, Value, Control>> DataTrack = new Dictionary<Key, KeyValueTriple<Key, Value, Control>>();

        public IEnumerator<KeyValueTriple<Key, Value, Control>> GetEnumerator()
        {
            foreach (KeyValueTriple<Key, Value, Control> val in DataTrack.Values) yield return val;
        }

        #endregion GetEnumerator

        #region Dictionary

        public List<Value> Values { get { return ValueDictionary.Values.ToList(); } }
        public Dictionary<Key, Value> ValueDictionary = new Dictionary<Key, Value>();

        public List<Control> Controls { get { return ControlDictionary.Values.ToList(); } }
        public Dictionary<Key, Control> ControlDictionary = new Dictionary<Key, Control>();

        public void Add(Key key, Value value, Control control) => Add(new KeyValueTriple<Key, Value, Control>(key, value, control));

        public void Add(KeyValueTriple<Key, Value, Control> KVT)
        {
            DataTrack.Add(KVT.Key, KVT);
            ValueDictionary.Add(KVT.Key, KVT.Value);
            ControlDictionary.Add(KVT.Key, KVT.Control);
        }

        public void Remove(Key key)
        {
            DataTrack.Remove(key);
            ValueDictionary.Remove(key);
            ControlDictionary.Remove(key);
        }

        public KeyValueTriple<Key, Value, Control> this[Key key]
        {
            get { return DataTrack[key]; }
            set
            {
                DataTrack[key] = value;
                ValueDictionary[key] = value.Value;
                ControlDictionary[key] = value.Control;
            }
        }

        #endregion Dictionary
    }

    public class SortedTrictionary<Key, Value, Control>
    {
        public SortedTrictionary()
        {
        }

        public SortedTrictionary(SortedTrictionary<Key, Value, Control> Trictionary)
        {
            foreach (KeyValueTriple<Key, Value, Control> U in (Trictionary.MemberwiseClone() as SortedTrictionary<Key, Value, Control>)) Add(U);
        }

        #region GetEnumerator

        public int Count { get { return DataTrack.Count(); } }
        public List<Key> Keys { get { return DataTrack.Keys.ToList(); } }
        private SortedDictionary<Key, KeyValueTriple<Key, Value, Control>> DataTrack = new SortedDictionary<Key, KeyValueTriple<Key, Value, Control>>();

        public IEnumerator<KeyValueTriple<Key, Value, Control>> GetEnumerator()
        {
            foreach (KeyValueTriple<Key, Value, Control> val in DataTrack.Values) yield return val;
        }

        #endregion GetEnumerator

        #region SortedDictionary

        public List<Value> Values { get { return ValueDictionary.Values.ToList(); } }
        public SortedDictionary<Key, Value> ValueDictionary = new SortedDictionary<Key, Value>();

        public List<Control> Controls { get { return ControlDictionary.Values.ToList(); } }
        public SortedDictionary<Key, Control> ControlDictionary = new SortedDictionary<Key, Control>();

        public void Add(Key key, Value value, Control control) => Add(new KeyValueTriple<Key, Value, Control>(key, value, control));

        public void Add(KeyValueTriple<Key, Value, Control> KVT)
        {
            DataTrack.Add(KVT.Key, KVT);
            ValueDictionary.Add(KVT.Key, KVT.Value);
            ControlDictionary.Add(KVT.Key, KVT.Control);
        }

        public void Remove(Key key)
        {
            DataTrack.Remove(key);
            ValueDictionary.Remove(key);
            ControlDictionary.Remove(key);
        }

        public KeyValueTriple<Key, Value, Control> this[Key key]
        {
            get { return DataTrack[key]; }
            set
            {
                DataTrack[key] = value;
                ValueDictionary[key] = value.Value;
                ControlDictionary[key] = value.Control;
            }
        }

        #endregion SortedDictionary
    }

    public partial class KeyValueTriple<key, value, control>
    {
        public KeyValueTriple(key _key, value _value, control _control)
        {
            Key = _key;
            Value = _value;
            Control = _control;
        }

        public key Key { get; set; } //  { get; }
        public value Value { get; set; }
        public control Control { get; set; }
        public object Tag { get; set; }
    }
}