namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// �õ�Ƭ��
    /// </summary>
    [Table("ImgFlash")]
    public partial class ImgFlash
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// �ϱ��⣨������100���֣�
        /// </summary>
        [Required]
        [StringLength(100)]
        public string TopTitle { get; set; }

        /// <summary>
        /// �±��⣨������100���֣�
        /// </summary>
        [Required]
        [StringLength(100)]
        public string BottomTitle { get; set; }

        /// <summary>
        /// ����ͼ��179�ַ�����,�Ƽ�715 * 290��
        /// </summary>
        [Required]
        [StringLength(500)]
        public string BackImg { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
