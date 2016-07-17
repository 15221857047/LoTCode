namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Ȩ�����
    /// </summary>
    [Table("RoleGroup")]
    public partial class RoleGroup
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ��ɫ��
        /// </summary>
        [Required]
        [StringLength(20)]
        public string RoleName { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
