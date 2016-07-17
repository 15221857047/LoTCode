namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ˵˵+�ճ��������һ�����ǲ��Ƽ����û����ģ�
    /// </summary>
    [Table("Talking")]
    public partial class Talking
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ���⣨���25���֣�
        /// </summary>
        [StringLength(25)]
        public string Title { get; set; }

        /// <summary>
        /// ���ݣ����500���֣�
        /// </summary>
        [Required]
        [StringLength(500)]
        public string Say { get; set; }

        /// <summary>
        /// չ��ͼ��Ĭ��ͼ��ǰ̨��Ĭ��ͼ���������ȡһ�ţ�
        /// </summary>
        [Required]
        [StringLength(179)]
        public string DisplayPic { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ����ʱ�䣨��һ�κʹ���ʱ����һ���ģ�
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public int HitCount { get; set; }

        /// <summary>
        /// ״̬��Ĭ��Ϊ0 0,�����˿ɼ���1,���ѿɼ���2,���Լ��ɼ�,99ɾ����
        /// </summary>
        public LoT.Enums.ArticleStatusEnum Status { get; set; }
    }
}
