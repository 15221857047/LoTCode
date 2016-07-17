namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ���·����
    /// </summary>
    [Table("ArticleType")]
    public partial class ArticleType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// �����������20���֣�
        /// </summary>
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// ��ID
        /// </summary>
        public int? Pid { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [ForeignKey("Pid")]
        public virtual ArticleType ParentType { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
