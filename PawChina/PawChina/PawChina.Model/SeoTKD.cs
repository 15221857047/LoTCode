namespace PawChina.Model
{
    /// <summary>
    /// SeoTKD��
    /// </summary>
    public partial class SeoTKD
    {
        public int Id { get; set; }

        /// <summary>
        /// SEO�ؼ��ʣ����ָ� 149�����ڣ�
        /// </summary>
        public string SeoKeywords { get; set; }

        /// <summary>
        /// SEO���ݣ�249�����ڣ�
        /// </summary>
        public string Sedescription { get; set; }

        /// <summary>
        /// ״̬��99Ϊɾ����
        /// </summary>
        public StatusEnum DataStatus { get; set; }
    }
}
