namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ����Ա��Ϣ��
    /// </summary>
    [Table("DntRootInfo")]
    public partial class DntRootInfo
    {
        /// <summary>
        /// ��ţ�Guid~��ֹ˳���£�
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// �ǳƣ����15���֣�
        /// </summary>
        [Required]
        [StringLength(15)]
        public string NoName { get; set; }

        /// <summary>
        /// ���루SHA����40λ��
        /// </summary>
        [Required]
        [StringLength(40)]
        public string NoPass { get; set; }

        /// <summary>
        /// ״̬��0 ������1 ���ᣬ99ɾ����
        /// </summary>
        public LoT.Enums.AdminEnum Status { get; set; }
    }
}
