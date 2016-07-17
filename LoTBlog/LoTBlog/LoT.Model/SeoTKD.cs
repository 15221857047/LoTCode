namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// SeoTKD��
    /// </summary>
    [Table("SeoTKD")]
    public partial class SeoTKD
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// SEO�ؼ��ʣ����ָ� 149�����ڣ�
        /// </summary>
        [Required]
        [StringLength(149)]
        public string SeoKeywords { get; set; }

        /// <summary>
        /// SEO���ݣ�249�����ڣ�
        /// </summary>
        [Required]
        [StringLength(249)]
        public string Sedescription { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
