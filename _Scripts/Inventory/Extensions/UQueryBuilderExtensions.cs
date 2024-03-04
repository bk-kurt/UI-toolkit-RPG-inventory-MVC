using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UIElements;

public static class UQueryBuilderExtensions {

    public static IEnumerable<T> OrderBy<T, TKey>(this UQueryBuilder<T> query, Func<T, TKey> keySelector, Comparer<TKey> @default)
        where T : VisualElement
    {
        return query.ToList().OrderBy(keySelector, @default);
    }
    
    public static IEnumerable<T> SortByNumericValue<T>(this UQueryBuilder<T> query, Func<T, float> keySelector)
        where T : VisualElement
    {
        return query.OrderBy(keySelector, Comparer<float>.Default);
    }
    
    public static T FirstOrDefault<T>(this UQueryBuilder<T> query)
        where T : VisualElement
    {
        return query.ToList().FirstOrDefault();
    }
    
    public static int CountWhere<T>(this UQueryBuilder<T> query, Func<T, bool> predicate) 
        where T : VisualElement 
    {
        return query.ToList().Count(predicate);
    }
}
