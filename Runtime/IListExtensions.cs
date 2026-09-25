using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityRandom = UnityEngine.Random;

namespace Unixtensions
{
    public static class IListExtensions
    {
        /// <summary>
        /// Gets a random element from the <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The source list.</param>
        /// <returns>A random element from the list.</returns>
        public static T GetRandom<T>(this IList<T> list) => list[UnityRandom.Range(0, list.Count)];

        /// <summary>
        /// Gets random elements from <paramref name="list"/> without selecting the same position more than once.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The source list.</param>
        /// <param name="count">Number of elements to select.</param>
        /// <param name="clampCount">Whether to limit <paramref name="count"/> to the number of elements in <paramref name="list"/>.</param>
        /// <returns>The selected elements in their original order. Equal values from different positions may appear more than once.</returns>
        public static List<T> GetRandoms<T>(this IList<T> list, int count, bool clampCount = false)
        {
            var listCount = list.Count;

            if (clampCount)
                count = Math.Min(count, listCount);

            var result = new List<T>(count);
            var remaining = listCount;

            for (var index = 0; count > 0; index++)
            {
                // Select each position with probability count / remaining.
                if (count == remaining || UnityRandom.Range(0, remaining) < count)
                {
                    result.Add(list[index]);

                    if (--count == 0)
                        break;
                }

                remaining--;
            }

            return result;
        }

        /// <summary>
        /// Returns a shuffled copy of <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The source list.</param>
        /// <returns>Shuffled copy.</returns>
        public static List<T> Shuffled<T>(this IList<T> list)
        {
            var result = list.ToList();
            result.Shuffle();
            return result;
        }

        /// <summary>
        /// Finds the element with the minimum value returned by <paramref name="keySelector"/>.
        /// </summary>
        /// <remarks>The selector must not modify the list.</remarks>
        /// <typeparam name="T">Element type.</typeparam>
        /// <typeparam name="TKey"><paramref name="keySelector"/> result type.</typeparam>
        /// <param name="list">The source list.</param>
        /// <param name="keySelector">Function used to calculate the value to compare for each element.</param>
        /// <returns>A tuple <c>(index, element)</c> for the first element with the minimum value.</returns>
        public static (int index, T element) MinBy<T, TKey>(this IList<T> list, Func<T, TKey> keySelector) where TKey : IComparable<TKey>
        {
            var count = list.Count;

            var minIndex = 0;
            var minElement = list[0];
            var minKey = keySelector(minElement);

            for (var index = 1; index < count; index++)
            {
                var candidateElement = list[index];
                var candidateKey = keySelector(candidateElement);

                if (candidateKey.CompareTo(minKey) >= 0)
                    continue;

                minIndex = index;
                minElement = candidateElement;
                minKey = candidateKey;
            }

            return (minIndex, minElement);
        }

        /// <summary>
        /// Finds the element with the maximum value returned by <paramref name="keySelector"/>.
        /// </summary>
        /// <remarks>The selector must not modify the list.</remarks>
        /// <typeparam name="T">Element type.</typeparam>
        /// <typeparam name="TKey"><paramref name="keySelector"/> result type.</typeparam>
        /// <param name="list">The source list.</param>
        /// <param name="keySelector">Function used to calculate the value to compare for each element.</param>
        /// <returns>A tuple <c>(index, element)</c> for the first element with the maximum value.</returns>
        public static (int index, T element) MaxBy<T, TKey>(this IList<T> list, Func<T, TKey> keySelector) where TKey : IComparable<TKey>
        {
            var count = list.Count;

            var maxIndex = 0;
            var maxElement = list[0];
            var maxKey = keySelector(maxElement);

            for (var index = 1; index < count; index++)
            {
                var candidateElement = list[index];
                var candidateKey = keySelector(candidateElement);

                if (candidateKey.CompareTo(maxKey) <= 0)
                    continue;

                maxIndex = index;
                maxElement = candidateElement;
                maxKey = candidateKey;
            }

            return (maxIndex, maxElement);
        }

        /// <summary>
        /// Removes and returns the element at <paramref name="index"/>.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="index">Index of element to pop.</param>
        /// <returns>The popped element.</returns>
        public static T Pop<T>(this IList<T> list, int index)
        {
            var element = list[index];
            list.RemoveAt(index);

            return element;
        }

        /// <summary>
        /// Removes and returns the elements at the specified <paramref name="indexes"/>.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="indexes">Unique indexes of elements to be popped.</param>
        /// <returns>The removed elements in the order of the supplied indexes.</returns>
        public static List<T> Pop<T>(this IList<T> list, params int[] indexes)
        {
            var popped = new List<T>(indexes.Length);

            foreach (var index in indexes)
                popped.Add(list[index]);

            var sortedIndexes = (int[])indexes.Clone();
            Array.Sort(sortedIndexes);

            for (var i = sortedIndexes.Length - 1; i >= 0; i--)
                list.RemoveAt(sortedIndexes[i]);

            return popped;
        }

        /// <summary>
        /// Removes and returns a random element from <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <returns>A tuple containing the removed element and its index before removal.</returns>
        public static (T element, int index) PopRandom<T>(this IList<T> list)
        {
            var index = UnityRandom.Range(0, list.Count);
            return (list.Pop(index), index);
        }

        /// <summary>
        /// Removes and returns random elements from the list.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="count">Count of elements to be popped.</param>
        /// <param name="clampCount">Whether to clamp <paramref name="count"/> between zero and the number of elements in <paramref name="list"/>.</param>
        /// <returns>Tuples containing each removed element and its index in the list immediately before that removal.</returns>
        public static List<(T element, int index)> PopRandoms<T>(this IList<T> list, int count, bool clampCount = false)
        {
            if (clampCount)
                count = Mathf.Clamp(count, 0, list.Count);

            var popped = new List<(T element, int index)>(count);

            for (int i = 0; i < count; i++)
                popped.Add(list.PopRandom());

            return popped;
        }

        /// <summary>
        /// Gets a random element and its index using the specified relative selection weights.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The source list.</param>
        /// <param name="probabilities">One finite, non-negative weight per element. At least one weight must be positive; the weights do not need to sum to one.</param>
        /// <returns>The selected element and its zero-based index. Elements with zero weight are never selected.</returns>
        public static (T element, int index) GetRandomWithProbability<T>(this IList<T> list, params float[] probabilities) => GetRandomWithProbability(list, (IList<float>)probabilities);

        /// <summary>
        /// Gets a random element and its index using relative selection weights.
        /// </summary>
        /// <remarks>
        /// Reads the list and weights by index without creating intermediate collections.
        /// The list and weights must remain unchanged during the call.
        /// </remarks>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The source list.</param>
        /// <param name="probabilities">One finite, non-negative weight per element. At least one weight must be positive; the weights do not need to sum to one.</param>
        /// <returns>The selected element and its zero-based index. Elements with zero weight are never selected.</returns>
        public static (T element, int index) GetRandomWithProbability<T>(this IList<T> list, IList<float> probabilities)
        {
            var count = list.Count;
            var totalWeight = 0d;
            var lastPositiveIndex = -1;

            for (var i = 0; i < count; i++)
            {
                var probability = probabilities[i];
                totalWeight += probability;

                if (probability > 0f)
                    lastPositiveIndex = i;
            }

            var randomValue = UnityRandom.value * totalWeight;
            var cumulativeWeight = 0d;

            for (var i = 0; i < count; i++)
            {
                var probability = probabilities[i];

                if (probability == 0f)
                    continue;

                cumulativeWeight += probability;

                if (randomValue < cumulativeWeight)
                    return (list[i], i);
            }

            // Handle the inclusive upper bound and rounding without selecting a zero-weight element.
            return (list[lastPositiveIndex], lastPositiveIndex);
        }

        /// <summary>
        /// Gets a random element and its index using weights returned by <paramref name="probabilitySelector"/>.
        /// </summary>
        /// <remarks>
        /// Each element is selected with probability proportional to its weight.
        /// Reads the list by index and invokes the selector exactly once per element.
        /// Uses constant additional memory without creating intermediate collections.
        /// The selector must not modify the list.
        /// </remarks>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The source list.</param>
        /// <param name="probabilitySelector">Returns a finite, non-negative weight for each element. At least one weight must be positive; the weights do not need to sum to one.</param>
        /// <returns>The selected element and its zero-based index. Elements with zero weight are never selected.</returns>
        public static (T element, int index) GetRandomWithProbability<T>(this IList<T> list, Func<T, float> probabilitySelector)
        {
            var count = list.Count;
            var selectedIndex = -1;
            var totalWeight = 0d;

            for (var index = 0; index < count; index++)
            {
                var element = list[index];
                var probability = probabilitySelector(element);

                if (probability == 0f)
                    continue;

                totalWeight += probability;

                if (selectedIndex < 0 || UnityRandom.value * totalWeight < probability)
                    selectedIndex = index;
            }

            return (list[selectedIndex], selectedIndex);
        }

        /// <summary>
        /// Removes and returns a random element using the specified relative selection weights.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="probabilities">Relative selection weights, one for each element in <paramref name="list"/>.</param>
        /// <returns>A tuple containing the removed element and its index before removal.</returns>
        public static (T element, int index) PopRandomWithProbability<T>(this IList<T> list, params float[] probabilities)
        {
            var random = list.GetRandomWithProbability(probabilities);
            Pop(list, random.index);

            return random;
        }

        /// <summary>
        /// Removes and returns a random element using the specified weight selector.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="probabilitiesSelector">Function that returns the relative selection weight of each element.</param>
        /// <returns>A tuple containing the removed element and its index before removal.</returns>
        public static (T element, int index) PopRandomWithProbability<T>(this IList<T> list, Func<T, float> probabilitiesSelector)
        {
            var random = list.GetRandomWithProbability(probabilitiesSelector);
            Pop(list, random.index);

            return random;
        }

        /// <summary>
        /// Removes all elements starting at <paramref name="index"/>.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="index">Index of the first element to remove.</param>
        public static void RemoveFrom<T>(this IList<T> list, int index)
        {
            for (int i = list.Count - 1; i >= index; i--)
                list.RemoveAt(i);
        }
        
        /// <summary>
        /// Shuffles <paramref name="list"/> in place.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The original list.</param>
        /// <returns>The original list after shuffling.</returns>
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            
            while (n > 1)
            {
                var index = UnityEngine.Random.Range(0, --n + 1);  
                (list[index], list[n]) = (list[n], list[index]);
            }

            return list;
        }

        /// <summary>
        /// Swaps two elements.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="list">The original list.</param>
        /// <param name="index1">First index to swap.</param>
        /// <param name="index2">Second index to swap.</param>
        /// <returns>Original list.</returns>
        public static IList<T> Swap<T>(this IList<T> list, int index1, int index2)
        {
            (list[index1], list[index2]) = (list[index2], list[index1]);
            return list;
        }
    }
}