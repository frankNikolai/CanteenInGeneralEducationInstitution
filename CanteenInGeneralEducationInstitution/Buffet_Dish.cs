//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CanteenInGeneralEducationInstitution
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buffet_Dish
    {
        public int ID_Buffet_Dish_RK { get; set; }
        public Nullable<int> ID_Buffet_FK { get; set; }
        public Nullable<int> ID_Dish_FK { get; set; }
    
        public virtual Buffet Buffet { get; set; }
        public virtual Dish Dish { get; set; }
    }
}
