using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShopping
{
    public class Cart
    {
        private static Cart instance;
        public static Cart Instance 
        { 
            get {
                if(instance == null)
                {
                    instance = new Cart();
                }
                return instance;
            } 
        }

        private Cart()
        {

        }

        public List<SanPham> sanPhams { get; set; } = new List<SanPham>();

        public void Close()
        {
            sanPhams.Clear();
        }

        public double GetTotalPrice()
        {
            if (sanPhams.Count() == 0)
            {
                return 0;
            }
            double totalPrice = 0;
            foreach (SanPham sanPham in sanPhams)
            {
                totalPrice += sanPham.GiaTien.Value * sanPham.SoLuong.Value;
            }
            return totalPrice;
        }

        public SanPham Find(int id)
        {
            if(sanPhams.Count() == 0)
            {
                return null;
            }
            foreach(SanPham sanPham in sanPhams)
            {
                if(sanPham.MaSanPham == id)
                {
                    return sanPham;
                }
            }
            return null;
        }

        public void Add(SanPham product)
        {
            if(sanPhams.Count() == 0)
            {
                var nProduct = product.Clone();
                nProduct.SoLuong = 1;
                sanPhams.Add(nProduct);
            } else
            {
                SanPham productInCart = Find(product.MaSanPham);
                if(productInCart != null)
                {
                    if (productInCart.SoLuong < product.SoLuong)
                    {
                        productInCart.SoLuong += 1;
                    }
                } else
                {
                    var nProduct = product.Clone();
                    nProduct.SoLuong = 1;
                    sanPhams.Add(nProduct);
                }
            }
        }

        public void RemoveOne(SanPham product)
        {
            if (sanPhams.Count() == 0)
            {
                return;
            }
            else
            {
                SanPham productInCart = Find(product.MaSanPham);
                if (productInCart != null)
                {
                    if (productInCart.SoLuong > 1)
                    {
                        productInCart.SoLuong -= 1;
                    }
                }
            }
        }
        public void Remove(SanPham product)
        {
            if (sanPhams.Count() == 0)
            {
                return;
            }
            else
            {
                SanPham productInCart = Find(product.MaSanPham);
                if (productInCart != null)
                {
                    sanPhams.Remove(productInCart);
                }
            }
        }

        public void Update(SanPham product)
        {
            if (sanPhams.Count() == 0)
            {
                return;
            }
            else
            {
                SanPham productInCart = Find(product.MaSanPham);
                if (productInCart != null)
                {
                    int index = sanPhams.IndexOf(productInCart);
                    sanPhams.Insert(index, product);
                }
            }
        }
    }
}
