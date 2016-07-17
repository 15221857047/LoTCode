namespace PawChina.Model
{
    public class ProTypeInfo
    {
        /// <summary>
        /// ���
        /// </summary>
		public int TId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
		public string TName { get; set; }
        /// <summary>
        /// ������
        /// </summary>
		public string TContent { get; set; }
        /// <summary>
        /// ������ID
        /// </summary>
        public int TPid { get; set; }
        /// <summary>
        /// ������
        /// </summary>
		public short TSort { get; set; }
        /// <summary>
        /// �����˵�
        /// </summary>
		public short TFloor { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
		public System.DateTime TCreateTime { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public ProductEnum TGroupType { get; set; }
        /// <summary>
        /// Ĭ��չͼ
        /// </summary>
		public string TDisplayPic { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
		public StatusEnum TDataStatus { get; set; }
    }
}
