﻿using System;

namespace PawChina.Model
{
    public class QueryModel
    {
        /// <summary>
        /// 当前索引
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页多少条
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 偏移量（PageIndex*PageSize）
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public string OrderStr { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public StatusEnum DataStatus { get; set; }
    }
}