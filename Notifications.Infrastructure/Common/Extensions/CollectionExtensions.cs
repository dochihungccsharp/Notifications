﻿namespace Notifications.Infrastructure.Common.Extensions;

public static class CollectionExtensions
{
    public static bool NotNullOrEmpty<T>(this IEnumerable<T> list)
        => list != null && list.Any();
}