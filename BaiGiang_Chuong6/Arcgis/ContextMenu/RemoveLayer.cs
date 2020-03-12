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

namespace ContextMenu
{
	public sealed class RemoveLayer : BaseCommand  
	{
		private IMapControl3 m_mapControl;

		public RemoveLayer()
		{
			base.m_caption = "X�a Layer";
		}
	
		public override void OnClick()
		{
			ILayer layer =  (ILayer) m_mapControl.CustomProperty;
			m_mapControl.Map.DeleteLayer(layer);
		}

        public override void OnCreate(object hook)
        {
            m_mapControl = (IMapControl3)hook;
        }

	}
}


