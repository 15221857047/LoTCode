namespace PawChina.Model
{
    /// <summary>
    /// 11���ֶ�
    /// </summary>
    public class NoteInfo
    {
        /// <summary>
        /// ���
        /// </summary>
        public int NId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string NTitle { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string NContent { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string NAuthor { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public int NHitCount { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public System.DateTime NCreateTime { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public System.DateTime NUpdateTime { get; set; }
        /// <summary>
        /// ����չͼ
        /// </summary>
        public string NDisplayPic { get; set; }
        /// <summary>
        /// �Ƿ����͵���ҳ
        /// </summary>
        public bool NPush { get; set; }
        /// <summary>
        /// SEO���ID
        /// </summary>
        public int NSeoId { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        public StatusEnum NDataStatus { get; set; }
    }
}
