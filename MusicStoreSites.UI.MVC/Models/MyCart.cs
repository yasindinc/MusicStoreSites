using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreSites.UI.MVC.Models
{
    public class MyCart
    {
        private Dictionary<int, CartItemDTO> _sepet = new Dictionary<int, CartItemDTO>();
        public List<CartItemDTO>GetAllCartItem
        {
            get
            {
                return _sepet.Values.ToList();
            }
        }
        public void Add(CartItemDTO cartItemDTO)
        {
            if(_sepet.ContainsKey(cartItemDTO.ID))
            {
                _sepet[cartItemDTO.ID].Amount += cartItemDTO.Amount;
                return;
            }
            _sepet.Add(cartItemDTO.ID, cartItemDTO);
        }
        public void Update(int id,short amount)
        {
            if(_sepet.ContainsKey(id))
            {
                _sepet[id].Amount = amount;
            }
        }
        public void Delete (int id)
        {
            if(_sepet.ContainsKey(id))
            {
                _sepet.Remove(id);
            }
        }
        public int TotalAmount
        {
            get
            {
                return _sepet.Values.Sum(x => x.Amount);
            }
        }

    }
}