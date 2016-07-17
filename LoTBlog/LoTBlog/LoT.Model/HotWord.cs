namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// �ȴʱ��û��ѵ��ȴʣ�
    /// </summary>
    [Table("HotWord")]
    public partial class HotWord
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ���ƣ�25���ڣ�
        /// </summary>
        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int HotCount { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
