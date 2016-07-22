using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawChina.Model
{
    /// <summary>
    /// ����Ա
    /// </summary>
    [Table("ChineseInfo")]
    public class ChineseInfo
    {
        /// <summary>
        /// GUID
        /// </summary>
        [Key]
		public string PawGid { get; set; }
        /// <summary>
        /// �û���
        /// </summary>
		public string PawName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
		public string PawPass { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
		public System.DateTime PawCreateTime { get; set; }
        /// <summary>
        /// �һ����������
        /// </summary>
        public string PawEmail { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        public StatusEnum PawDataStatus { get; set; }
    }
}
