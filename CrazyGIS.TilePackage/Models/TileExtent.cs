﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyGIS.TilePackage.Models
{
	public class TileExtent
	{
		public TileExtent() { }

		public ProjectionType ProjType { get; set; }

		public int ZoomLevel { get; set; }

		public double ZoomResolution { get; set; }

		public double ZoomScale { get; set; }

		public int RowNumber { get; set; }

		public int ColumnNumber { get; set; }

		public int MinRowIndex { get; set; }

		public int MinColumnIndex { get; set; }

		public int MaxRowIndex { get; set; }

		public int MaxColumnIndex { get; set; }
	}
}
