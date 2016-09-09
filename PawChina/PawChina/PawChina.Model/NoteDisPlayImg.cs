using Dapper.Contrib.Extensions;

namespace PawChina.Model
{
    /// <summary>
    /// �ʼ�Ĭ��չͼ
    /// </summary>
    [Table("NoteDisPlayImg")]
    public class NoteDisPlayImg
    {
        /// <summary>
        /// ���
        /// </summary>
        [Key]
        public int DId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string DTitle { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string DPicUrl { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        public StatusEnum DataStatus { get; set; }
    }
}