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
    
    public partial class pl_menu
    {
        public int menu_gkey { get; set; }
        public string menu_frm_id { get; set; }
        public string menu_title { get; set; }
        public int menu_parent_key { get; set; }
        public int menu_has_child { get; set; }
        public string menu_type { get; set; }
        public string menu_function_name { get; set; }
        public string menu_exe_path { get; set; }
        public Nullable<int> menu_record_status { get; set; }
        public int menu_creator { get; set; }
        public System.DateTime menu_creation_time { get; set; }
        public int menu_latest_editor { get; set; }
        public System.DateTime menu_updated_time { get; set; }
    }
}
