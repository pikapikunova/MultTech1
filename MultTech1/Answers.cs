//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultTech1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Answers()
        {
            this.Questions = new HashSet<Questions>();
        }
    
        public int id { get; set; }
        public string falseAnsw { get; set; }
        public string trueAnsw { get; set; }
        public bool radioBut { get; set; }
        public bool checkBox { get; set; }
        public bool texBox { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Questions> Questions { get; set; }
    }
}