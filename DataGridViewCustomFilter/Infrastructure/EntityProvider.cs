using System.Collections.Generic;

namespace DataGridViewCustomFilter.Infrastructure
{
    public interface EntityProvider<T>
    {
        List<T> GetEntities();
    }
}
