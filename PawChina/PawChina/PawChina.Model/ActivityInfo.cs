using Dapper.Contrib.Extensions;

namespace PawChina.Model
{
    [Table("ActivityInfo")]
    public class ActivityInfo
    {
        /// <summary>
        /// ���
        /// </summary>
        [Key]
		public int AId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
		public string ATitle { get; set; }
        /// <summary>
        /// Ӣ�ı���
        /// </summary>
		public string ATitleEn { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public string AContent { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
		public System.DateTime ACreateTime { get; set; }
        /// <summary>
        /// Ĭ��չͼ
        /// </summary>
		public string ADisplayPic { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
		public StatusEnum ADataStatus { get; set; }
    }
}
