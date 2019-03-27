using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentTXT
{
    public class MapText<T> where T : class, new()
    {
        private List<MappingRule<T>> Rules = new List<MappingRule<T>>();

        private int _maxLenght = 380; // si si, vergognoso... ma è inutile che lo aggiusto se la libreria fa cagare

        public MapText<T> SetMapFor(Func<string, T, T> expression, int start, int length)
        {
            var rule = new MappingRule<T>();
            rule.Start = start;
            rule.Length = length;
            var func = expression;
            rule.SetPropertyRule(func);
            Rules.Add(rule);
            return this;
        }


        public List<T> Get(string _workingText)
        {
            List<T> listToReturn = new List<T>();

            var baseCount = 0;
            while (baseCount + _maxLenght < _workingText.Length)
            {
                T context = new T();
                foreach (var rule in Rules)
                {
                    context = rule.GetObjectWithDataMapped(context, _workingText, baseCount);
                }                
                baseCount += _maxLenght;
                listToReturn.Add(context);
            }


            return listToReturn;
        }
    }
}
