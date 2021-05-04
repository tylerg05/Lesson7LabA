using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7LabA
{
    class TylerFactData
    {
        public TylerFactData()
        {

        }
        public static IEnumerable<TylerFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        static TylerFactData()
        {
            List<TylerFactData> all = new List<TylerFactData>();
            all.Add(new TylerFactData() { TheFact = "Tyler has visited Costa Rica on a school trip.", ShortFact = "Central America" });
            all.Add(new TylerFactData() { TheFact = "Tyler is the shortest member of his immediate family.", ShortFact = "Short Fact" });
            all.Add(new TylerFactData() { TheFact = "Tyler has lived in four different states.", ShortFact = "Homes" });
            all.Add(new TylerFactData() { TheFact = "Tyler's favorite color is purple and his favorite animal is the giraffe.", ShortFact = "Favorites" });
            all.Add(new TylerFactData() { TheFact = "Tyler has marched in a marching band at Disney's Epcot in Florida.", ShortFact = "Marching Band" });
            All = all;
        }
    }
}
