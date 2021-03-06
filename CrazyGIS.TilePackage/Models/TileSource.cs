﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyGIS.TilePackage.Models
{
	/// <summary>
	/// 瓦片源
	/// </summary>
	public class TileSource
	{
		/// <summary>
		/// 投影类型
		/// </summary>
		public ProjectionType ProjType { get; set; }

		/// <summary>
		/// 瓦片源类型
		/// </summary>
		public TileSourceType SourceType { get; set; }

		/// <summary>
		/// 数据源路径
		/// </summary>
		public string SourceUrl { get; set; }

		/// <summary>
		/// 坐标范围
		/// </summary>
		public CoordinateExtent CoordExtent { get; set; }
	}
}
