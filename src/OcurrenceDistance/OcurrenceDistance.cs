using System;
using System.Collections.Generic;
using System.Linq;

namespace OccurrenceDistance
{
    public class OcurrenceDistance<T>
    {
        public Dictionary<T, long> ItemsCount = new Dictionary<T, long>();
        public Dictionary<T, double> ItemsFrequencyDictionary = new Dictionary<T, double>();

        public OcurrenceDistance(IEnumerable<IDistanciable<T>> source)
        {
            ComputeItemFrequency(source);
        }

        public double SimilarityTo(IDistanciable<T> item)
        {
            if (ItemsFrequencyDictionary.Count == 0)
                throw new Exception("No items computed.");

            T[] values = item.GetDistanciableItems();
            double score = 0.0;

            foreach (var t in values.Intersect(ItemsFrequencyDictionary.Select(x => x.Key).ToArray()))
            {
                score += ItemsFrequencyDictionary[t];
            }

            return score;
        }

        public IDictionary<T, double> GetItemsFrequency()
        {
            return ItemsFrequencyDictionary;
        }

        private void ComputeItemFrequency(IEnumerable<IDistanciable<T>> items)
        {
            items.ToList().ForEach(item =>
            {
                foreach (var t in item.GetDistanciableItems())
                {
                    if (!ItemsCount.ContainsKey(t))
                    {
                        ItemsCount.TryAdd(t, 1);
                    }
                    else
                    {
                        ItemsCount[t]++;
                    }
                }
            });

            long totalItems = ItemsCount.Sum(x => x.Value);
            ItemsCount.ToList().ForEach(item =>
            {
                ItemsFrequencyDictionary.TryAdd(item.Key, (((double)item.Value * 100) / totalItems));
            });
        }
    }
}
