using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Globalization;

namespace BDSA2020.Assignment02
{
    public class Wizard
    {
        public string Name { get; set; }

        // Book or film or...
        public string Medium { get; set; }

        public int? Year { get; set; }

        public string Creator { get; set; }

        public static Lazy<IReadOnlyCollection<Wizard>> Wizards { get; } = new Lazy<IReadOnlyCollection<Wizard>>(() =>
        {
            var csv = File.OpenText("../../../../Wizards.csv");
            using var reader = new CsvReader(csv, CultureInfo.InvariantCulture);
            return reader.GetRecords<Wizard>().ToList().AsReadOnly();
        });
    }
}
