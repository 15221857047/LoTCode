namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ����ԱȨ�޹�����[��ɫȨ�ޱ�]
    /// </summary>
    [Table("RootAndAction")]
    public partial class RootAndAction
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// �Ƿ���Ȩ��
        /// </summary>
        public bool IsPass { get; set; }

        /// <summary>
        /// ����Ա��Ϣ�����
        /// </summary>
        [Required]
        [StringLength(40)]
        public string UserId { get; set; }

        /// <summary>
        /// ����ԱȨ�ޱ����
        /// </summary>
        public int ActionInfoId { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
