//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class pl_func_parameters
    {
        public pl_func_parameters()
        {
            this.pl_function_priviledge = new HashSet<pl_function_priviledge>();
        }
    
        public int func_para_gkey { get; set; }
        public string func_para_menu_title { get; set; }
        public string func_para_function_name { get; set; }
        public string func_para_function_desciption { get; set; }
        public string func_para_control_name { get; set; }
        public string func_para_control_description { get; set; }
        public int func_para_creator { get; set; }
        public System.DateTime func_para_creator_time { get; set; }
        public int func_para_latest_editor { get; set; }
        public System.DateTime func_para_updated_time { get; set; }
        public Nullable<int> func_para_record_status { get; set; }
    
        public virtual ICollection<pl_function_priviledge> pl_function_priviledge { get; set; }
    }
}