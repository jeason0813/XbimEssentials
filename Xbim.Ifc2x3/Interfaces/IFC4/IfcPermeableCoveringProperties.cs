// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ArchitectureDomain
{
	public partial class @IfcPermeableCoveringProperties : IIfcPermeableCoveringProperties
	{
		Xbim.Ifc4.ArchitectureDomain.IfcPermeableCoveringOperationEnum IIfcPermeableCoveringProperties.OperationType 
		{ 
			get
			{
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelPositionEnum IIfcPermeableCoveringProperties.PanelPosition 
		{ 
			get
			{
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcPermeableCoveringProperties.FrameDepth 
		{ 
			get
			{
				if (FrameDepth == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)FrameDepth);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcPermeableCoveringProperties.FrameThickness 
		{ 
			get
			{
				if (FrameThickness == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)FrameThickness);
			} 
		}
		IIfcShapeAspect IIfcPermeableCoveringProperties.ShapeAspectStyle 
		{ 
			get
			{
				return ShapeAspectStyle as IIfcShapeAspect;
			} 
		}
	}
}