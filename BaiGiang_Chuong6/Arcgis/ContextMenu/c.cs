// Copyright 2010 ESRI
// 
// All rights reserved under the copyright laws of the United States
// and applicable international laws, treaties, and conventions.
// 
// You may freely redistribute and use this sample code, with or
// without modification, provided you include the original copyright
// notice and use restrictions.
// 
// See the use restrictions at http://help.arcgis.com/en/sdk/10.0/usageRestrictions.htm
// 

using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;

namespace ContextMenu
{
	public class ScaleThresholds : BaseCommand, ICommandSubType
	{
		private IMapControl3 m_mapControl;
		private long m_subType;

		public ScaleThresholds()
		{

		}
	
		public override void OnClick()
		{
			ILayer layer = (ILayer) m_mapControl.CustomProperty;
			if (m_subType == 1) layer.MaximumScale = m_mapControl.MapScale;
			if (m_subType == 2) layer.MinimumScale = m_mapControl.MapScale;
			if (m_subType == 3)
			{
				layer.MaximumScale = 0;
				layer.MinimumScale = 0;
			}
			m_mapControl.Refresh(esriViewDrawPhase.esriViewGeography,null,null);
		}
	
		public override void OnCreate(object hook)
		{
			m_mapControl = (IMapControl3) hook;
		}
	
		public int GetCount()
		{
			return 3;
		}
	
		public void SetSubType(int SubType)
		{
			m_subType = SubType;
		}
	
		public override string Caption
		{
			get
			{
				if (m_subType == 1) return "Set Maximum Scale";
				else if (m_subType == 2) return "Set Minimum Scale";
				else return "Remove Scale Thresholds";
			}
		}
	
		public override bool Enabled
		{
			get
			{
				bool enabled = true;
				ILayer layer = (ILayer) m_mapControl.CustomProperty;
				
				if (m_subType == 3)
				{
					if ((layer.MaximumScale == 0) & (layer.MinimumScale == 0)) enabled = false;
				}
				return enabled;
			}
		}
	}
}

