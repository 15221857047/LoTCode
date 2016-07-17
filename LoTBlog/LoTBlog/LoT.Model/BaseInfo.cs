namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ������
    /// </summary>
    [Table("BaseInfo")]
    public partial class BaseInfo
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ͷ�����⣨������29���֣�
        /// </summary>
        [Required]
        [StringLength(29)]
        public string TopTitle { get; set; }

        /// <summary>
        /// ͷ����飨������100���֣�
        /// </summary>
        [Required]
        [StringLength(100)]
        public string TopText { get; set; }

        /// <summary>
        /// ͷ��Logo����(���·��·��)
        /// </summary>
        [Required]
        [StringLength(300)]
        public string TopLogoOne { get; set; }

        /// <summary>
        /// ͷ��Logo����(���·��·��)
        /// </summary>
        [Required]
        [StringLength(300)]
        public string TopLogoTwo { get; set; }

        /// <summary>
        /// �Ҳ�ͷ�����·����
        /// </summary>
        [Required]
        [StringLength(300)]
        public string RightImg { get; set; }

        /// <summary>
        /// �Ҳ���⣨������29���֣�
        /// </summary>
        [Required]
        [StringLength(29)]
        public string RightTitle { get; set; }

        /// <summary>
        /// �Ҳ����ԣ�������29���֣�
        /// </summary>
        [Required]
        [StringLength(29)]
        public string Manifesto { get; set; }

        /// <summary>
        /// �����ǳƣ�������29���֣�
        /// </summary>
        [Required]
        [StringLength(29)]
        public string Nickname { get; set; }

        /// <summary>
        /// �ܶ�Ŀ�꣨������29���֣�
        /// </summary>
        [Required]
        [StringLength(29)]
        public string Goal { get; set; }

        /// <summary>
        /// ������루������29���֣�
        /// </summary>
        [Required]
        [StringLength(29)]
        public string Dream { get; set; }

        /// <summary>
        /// ���QQ�ţ�int���͵����֣�
        /// </summary>
        public int QQ { get; set; }

        /// <summary>
        /// ������䣨�������ĵ����䣩
        /// </summary>
        [Required]
        [StringLength(29)]
        public string Email { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }

        #region ��ɾ
        ///// <summary>
        ///// LoTBlog�İ汾��(Ӣ��_����_������25λ)
        ///// </summary>
        //[Required]
        //[StringLength(25)]
        //public string LoTVersion { get; set; }

        ///// <summary>
        ///// ��������
        ///// </summary>
        //[Required]
        //[StringLength(15)]
        //public string DntName { get; set; }

        ///// <summary>
        ///// ��ϵ���ߣ�һ�����䷢�͵����ӣ�
        ///// </summary>
        //[Required]
        //[StringLength(50)]
        //public string LinkDnt { get; set; } 
        #endregion

    }
}
