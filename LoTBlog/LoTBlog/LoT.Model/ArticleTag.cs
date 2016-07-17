namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Tag��ϵͳ��һЩ���ࡾһ�����¿����ж����ǩ����
    /// </summary>
    [Table("ArticleTag")]
    public partial class ArticleTag
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ���ƣ�15�����ڣ�
        /// </summary>
        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
