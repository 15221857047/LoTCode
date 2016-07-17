namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ����ԱȨ�ޱ�
    /// </summary>
    [Table("ActionInfo")]
    public partial class ActionInfo
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Ȩ����
        /// </summary>
        [Required]
        [StringLength(30)]
        public string ActionName { get; set; }

        /// <summary>
        /// �����ַ
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Url { get; set; }

        /// <summary>
        /// Http״̬��post get��
        /// </summary>
        public int HttpMethod { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime SubTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Ȩ��״̬
        /// </summary>
        public LoT.Enums.StatusEnum Statu { get; set; }

        /// <summary>
        /// Ȩ������
        /// </summary>
        public int ActionInfoType { get; set; }
    }
}
