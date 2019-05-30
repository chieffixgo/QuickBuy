using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public string UsuarioId { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um pedido 
        /// ou muitos pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
