namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ͳ�Ʊ��������ö�ʱ����ÿ��12.00����һ�Ρ�����ͳ�Ʊ�Ͳ���ÿ�μ����Լ����Դ����
    /// </summary>
    [Table("Census")]
    public partial class Census
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ���ƣ�27�����ڣ�
        /// </summary>
        [Required]
        [StringLength(27)]
        public string Name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
