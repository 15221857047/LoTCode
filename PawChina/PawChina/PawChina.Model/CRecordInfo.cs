using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawChina.Model
{
    [Table("CRecordInfo")]
    public class CRecordInfo
	{
        /// <summary>
        /// GUID
        /// </summary>
        [Key]
		public string RGuid { get; set; }
        /// <summary>
        /// �����ߵ�IP��ַ
        /// </summary>
		public string RIP { get; set; }
        /// <summary>
        /// �����ߵĳ���
        /// </summary>
		public string RCity { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
		public StatusEnum RStatus { get; set; }
	}
}
