using System.Collections.Generic;
namespace LinQ_Learn
{
    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }

        static List<Brand> _brands;
        public static List<Brand> brands
        {
            get
            {
                if (_brands == null)
                {
                    _brands = new List<Brand>() {
                        new Brand{ID = 1, Name = "Company 1"},
                        new Brand{ID = 2, Name = "Company 2"},
                        new Brand{ID = 4, Name = "Company 3"},
                    };
                }
                return _brands;
            }
        }
    }
}
