//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Logs
    {
        public int id { get; set; }
        public Nullable<int> author_id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string operatevent { get; set; }
    
        public virtual Author Author { get; set; }
    }
}
