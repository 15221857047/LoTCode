namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ����
    /// </summary>
    [Table("Article")]
    public partial class Article
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ���⣨���50���֣�
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        /// <summary>
        /// ���ߣ����15���֣�
        /// </summary>
        [Required]
        [StringLength(15)]
        public string Author { get; set; }

        /// <summary>
        /// �������ݣ�����Ϊ�գ�
        /// </summary>
        [Required]
        public string TContent { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public int HitCount { get; set; }

        /// <summary>
        /// ��������0����ǰ��
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// ���������Ѷ1 �ʼ�2 ������Դ3��
        /// </summary>
        public LoT.Enums.GroupEnum GroupType { get; set; }

        /// <summary>
        /// �Ƽ����� 0���Ƽ� 1�༭�Ƽ� 2�����Ƽ� 3�����Ƽ� 4��ҳ�ö�
        /// </summary>
        public LoT.Enums.RecommendEnum Recommend { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// ����(,�ָ�)
        /// </summary>
        [Required]
        [StringLength(100)]
        public string TypeIds { get; set; }

        /// <summary>
        /// SeoId�����������Seo��Ϣ��SEOTKD���棩
        /// </summary>
        public int? SeoId { get; set; }

        [ForeignKey("SeoId")]
        public virtual SeoTKD SeoInfo { get; set; }

        /// <summary>
        /// ������ǩ��tagid�ã��ָ��������50���ַ���
        /// </summary>
        [Required]
        [StringLength(100)]
        public string TagIds { get; set; }

        /// <summary>
        /// ״̬��Ĭ��Ϊ0 0,�����˿ɼ���1,���ѿɼ���2,���Լ��ɼ�,99ɾ����
        /// </summary>
        public LoT.Enums.ArticleStatusEnum Status { get; set; }


        /// <summary>
        /// Ĭ��չͼ
        /// </summary>
        [Required]
        [StringLength(179)]
        public string DisplayPic { get; set; }
    }
}
