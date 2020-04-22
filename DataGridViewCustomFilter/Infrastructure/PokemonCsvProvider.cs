using CsvHelper;
using DataGridViewCustomFilter.Entity;
using DataGridViewCustomFilter.Properties;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace DataGridViewCustomFilter.Infrastructure
{
    public class PokemonCsvProvider : PokemonProvider
    {
        public List<Pokemon> GetEntities()
        {
            // TODO: リソースファイル固定値なのどうにかする
            var result = new List<Pokemon>();
            using (var reader = new StringReader(Resources.pokemon_swordshield))
            {
                using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                {
                    csv.Read();
                    csv.ReadHeader();
                    var records = csv.GetRecords<Pokemon>();
                    foreach (var record in records)
                    {
                        result.Add(record);
                    }
                }
            }
            return result;
        }
    }
}
