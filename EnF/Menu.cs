//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Type { get; set; }
        public bool IsNewTab { get; set; }
        public Nullable<int> Pos { get; set; }
        public string EName { get; set; }
    }
}