namespace LoT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ��������
    /// </summary>
    [Table("FriendLink")]
    public partial class FriendLink
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ��������15�����ڣ�
        /// </summary>
        [Required]
        [StringLength(15)]
        public string LinkName { get; set; }

        /// <summary>
        /// ��վ��ַ��50�ַ����ڣ�
        /// </summary>
        [Required]
        [StringLength(50)]
        public string WebUrl { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public LoT.Enums.StatusEnum Status { get; set; }

        /// <summary>
        /// ���򣨽������У�
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public LoT.Enums.LinkTypeEnum LinkType { get; set; }
    }
}
