namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ���۱�
    /// </summary>
    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// �ǳƣ����15���֣�
        /// </summary>
        [Required]
        [StringLength(15)]
        public string Nickname { get; set; }

        /// <summary>
        /// ���⡾�ɿա������25���֣�
        /// </summary>
        [StringLength(25)]
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required]
        public string Context { get; set; }

        /// <summary>
        /// ������ͨ��API�õ���
        /// </summary>
        [Required]
        [StringLength(25)]
        public string Address { get; set; }

        /// <summary>
        /// IP��ַ�����64λ��
        /// </summary>
        [Required]
        [StringLength(64)]
        public string IPAddress { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }
    }
}
