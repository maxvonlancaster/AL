using System.Collections.ObjectModel;

namespace AL.Services
{
    public class DataFrameService
    {
    }

    public class DataFrame 
    {
        public void Add(string column, int[] ints)
        {
            
        }

        public IEnumerable<DataFrameRow> Rows { get; set; }

        public int GetData(string column, int row) 
        {
            return Rows.First(r => r.Name == column).Data[row];
        }
    }

    public class DataFrameRow 
    {
        public string? Name { get; set; }
        public Collection<int> Data { get; set; }
    }
}
