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
namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	public partial class @IfcServiceLife : IIfcControl
	{
		Xbim.Ifc4.MeasureResource.IfcIdentifier? IIfcControl.Identification 
		{ 
			get
			{
				throw new System.NotImplementedException();
			} 
		}
		IEnumerable<IIfcRelAssignsToControl> IIfcControl.Controls 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssignsToControl>(e => (e.RelatingControl as IfcServiceLife) == this);
			} 
		}
	}
}