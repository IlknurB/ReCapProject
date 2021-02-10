using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        
            IBrandDal _brandDal;

            public BrandManager(IBrandDal brandDal)
            {
                _brandDal = brandDal;
            }

            public void Add(Brand brand)
            {
                if (brand.BrandName.Length >= 2)
                {
                    _brandDal.Add(brand);
                    Console.WriteLine("{0} - Marka adı başarıyla eklendi", brand.BrandName);
                }
                else
                {
                    Console.WriteLine($"marka ismini 2 harften fazla giriniz {brand.BrandName}");
                }
            }

        }
}
