//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kirill2._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderproduct
    {
        public int id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> productid { get; set; }
        public string count { get; set; }
        public Nullable<int> orderid { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
