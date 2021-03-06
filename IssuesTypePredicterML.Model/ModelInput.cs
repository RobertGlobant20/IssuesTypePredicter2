// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace IssuesTypePredicterML.Model
{
    public class ModelInput
    {
        [ColumnName("Number"), LoadColumn(0)]
        public float Number { get; set; }


        [ColumnName("IsWishList"), LoadColumn(1)]
        public string IsWishList { get; set; }


        [ColumnName("Title"), LoadColumn(2)]
        public string Title { get; set; }


        [ColumnName("Description"), LoadColumn(3)]
        public string Description { get; set; }


    }
}
