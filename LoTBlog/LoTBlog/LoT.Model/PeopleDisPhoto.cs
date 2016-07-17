namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// �ÿ�Ĭ��չͼ
    /// </summary>
    [Table("PeopleDisPhoto")]
    public partial class PeopleDisPhoto
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ���⣨����ͷ������ʾ��alt��15�������ڣ�
        /// </summary>
        [Required]
        [StringLength(15)]
        public string Title { get; set; }

        /// <summary>
        /// ͼƬ·��
        /// </summary>
        [Required]
        [StringLength(179)]
        public string PicUrl { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
