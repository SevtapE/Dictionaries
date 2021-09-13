using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class MyDictionary<TKey, TValue>
    {

        TKey[] _arrayKeys;
        TValue[] _arrayValues;

        TKey[] _tempArrayKey;
        TValue[] _tempArrayValue;

       

        public MyDictionary()
        {
            _arrayKeys = new TKey[0];
            _arrayValues = new TValue[0];
          
        }
        public void Add(TKey key, TValue value)
        {
            //hold the old references 
            _tempArrayKey = _arrayKeys;
            _tempArrayValue = _arrayValues;

            _arrayKeys = new TKey[_arrayKeys.Length + 1];
            _arrayValues = new TValue[_arrayValues.Length + 1];


            for (int i = 0; i < _tempArrayKey.Length; i++)
            {
                _arrayKeys[i] = _tempArrayKey[i];
            }
            for (int i = 0; i < _tempArrayValue.Length; i++)
            {
                _arrayValues[i] = _tempArrayValue[i];
            }

            _arrayKeys[_arrayKeys.Length - 1] = key;
            _arrayValues[_arrayValues.Length - 1] = value;

            //just for me - control
            Console.WriteLine($"{_arrayKeys[_arrayKeys.Length - 1]} , {_arrayValues[_arrayValues.Length - 1]} is added.(index :  {_arrayKeys.Length - 1} )");
        }
       
    }
   
}
