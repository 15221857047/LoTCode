namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// �������
    /// </summary>
    [Table("PhotoType")]
    public partial class PhotoType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        /// <summary>
        /// ��飨249�����ڣ�
        /// </summary>
        [StringLength(249)]
        public string Introduction { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
