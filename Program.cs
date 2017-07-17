using System;
using System.Data;

namespace ProbabilityFunctions
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sex");
            table.Columns.Add("Billshape", typeof(double));
            table.Columns.Add("Size", typeof(double));
            table.Columns.Add("Throatcolor", typeof(double));
            table.Columns.Add("Wingshape", typeof(double));
            table.Columns.Add("Wingpattern", typeof(double));

            //training data.
            table.Rows.Add("albatross", 1, 7, 1, 1, 3);
            table.Rows.Add("albatross", 2, 24, 1, 2, 4);
            table.Rows.Add("albatross", 1, 13, 2, 2, 4);
            table.Rows.Add("albatross", 1, 13, 2, 1, 3);
            table.Rows.Add("albatross", 2, 13, 2, 5, 3);
            table.Rows.Add("albatross", 1, 13, 1, 5, 3);

            table.Rows.Add("auklet", 5, 7, 7, 2, 3);
            table.Rows.Add("auklet", 5, 7, 7, 3, 3);
            table.Rows.Add("auklet", 5, 7, 8, 3, 2);
            table.Rows.Add("auklet", 9, 13, 9, 2, 2);
            table.Rows.Add("auklet", 6, 13, 8, 2, 2);
            table.Rows.Add("auklet", 6, 13, 7, 2, 4);
            table.Rows.Add("auklet", 6, 13, 7, 2, 3);

            table.Rows.Add("blackbird", 5, 4, 5, 3, 4);
            table.Rows.Add("blackbird", 9, 7, 6, 1, 4);
            table.Rows.Add("blackbird", 5, 7, 7, 2, 3);
            table.Rows.Add("blackbird", 9, 7, 7, 2, 3);
            table.Rows.Add("blackbird", 9, 7, 6, 3, 2);
            table.Rows.Add("blackbird", 9, 7, 3, 3, 3);


            Classifier classifier = new Classifier();
            classifier.TrainClassifier(table);

            Console.WriteLine(classifier.Classify(new double[] { 5, 7, 6, 3, 2 }));
            Console.Read();
        }
    }
}