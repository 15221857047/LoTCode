namespace PawChina.Model
{
    public class ProductInfo
    {
        /// <summary>
        /// ��Ʒ���
        /// </summary>
		public int PId { get; set; }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
		public string PTitle { get; set; }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
		public string PContent { get; set; }
        /// <summary>
        /// ���� ~ Խ��Խ��ǰ
        /// </summary>
		public short PSort { get; set; }
        /// <summary>
        /// ҳ�������
        /// </summary>
		public int PHitCount { get; set; }
        /// <summary>
        /// ��Ʒ����ʱ��
        /// </summary>
		public System.DateTime PCreateTime { get; set; }
        /// <summary>
        /// ��Ʒ����ʱ��
        /// </summary>
		public System.DateTime PUpdateTime { get; set; }
        /// <summary>
        /// ��Ʒ���ͣ��ǲ�Ʒ�������
        /// </summary>
		public ProductEnum PGroupType { get; set; }
        /// <summary>
        /// ��Ʒչͼ
        /// </summary>
        public string PDisplayPic { get; set; }
        /// <summary>
        /// �Ƿ����͵���ҳ
        /// </summary>
        public bool PPush { get; set; }
        /// <summary>
        /// Seo���ID
        /// </summary>
        public int PSeoId { get; set; }
        /// <summary>
        /// ��Ʒ�������ID
        /// </summary>
        public int PTypeId { get; set; }
        /// <summary>
        /// ��Ʒ״̬
        /// </summary>
		public StatusEnum PDataStatus { get; set; }
    }
}
