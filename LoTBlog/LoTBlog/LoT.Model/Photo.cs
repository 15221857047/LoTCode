namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ���
    /// </summary>
    [Table("Photo")]
    public partial class Photo
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ���⣨15���ڣ�
        /// </summary>
        [Required]
        [StringLength(15)]
        public string Title { get; set; }

        /// <summary>
        /// ���չʾͼ��ַ
        /// </summary>
        [Required]
        [StringLength(179)]
        public string DisPlayPic { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }

        /// <summary>
        /// ���򣨽������У�
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        public int PTypeId { get; set; }
    }
}
