namespace PawChina.Model
{
	public class CRecordInfo
	{
        /// <summary>
        /// GUID
        /// </summary>
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
