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
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcSlab : IIfcSlab
	{

		[CrossSchemaAttribute(typeof(IIfcSlab), 9)]
		Ifc4.Interfaces.IfcSlabTypeEnum? IIfcSlab.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcSlabTypeEnum.APPROACH_SLAB:
						//## Handle translation of APPROACH_SLAB member from IfcSlabTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcSlabTypeEnum>();
						//##
					case IfcSlabTypeEnum.BASESLAB:
						return Ifc4.Interfaces.IfcSlabTypeEnum.BASESLAB;
					case IfcSlabTypeEnum.FLOOR:
						return Ifc4.Interfaces.IfcSlabTypeEnum.FLOOR;
					case IfcSlabTypeEnum.LANDING:
						return Ifc4.Interfaces.IfcSlabTypeEnum.LANDING;
					case IfcSlabTypeEnum.PAVING:
						//## Handle translation of PAVING member from IfcSlabTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcSlabTypeEnum>();
						//##
					case IfcSlabTypeEnum.ROOF:
						return Ifc4.Interfaces.IfcSlabTypeEnum.ROOF;
					case IfcSlabTypeEnum.SIDEWALK:
						//## Handle translation of SIDEWALK member from IfcSlabTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcSlabTypeEnum>();
						//##
					case IfcSlabTypeEnum.TRACKSLAB:
						//## Handle translation of TRACKSLAB member from IfcSlabTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcSlabTypeEnum>();
						//##
					case IfcSlabTypeEnum.WEARING:
						//## Handle translation of WEARING member from IfcSlabTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcSlabTypeEnum>();
						//##
					case IfcSlabTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcSlabTypeEnum.USERDEFINED;
					case IfcSlabTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSlabTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcSlabTypeEnum.FLOOR:
						PredefinedType = IfcSlabTypeEnum.FLOOR;
						return;
					case Ifc4.Interfaces.IfcSlabTypeEnum.ROOF:
						PredefinedType = IfcSlabTypeEnum.ROOF;
						return;
					case Ifc4.Interfaces.IfcSlabTypeEnum.LANDING:
						PredefinedType = IfcSlabTypeEnum.LANDING;
						return;
					case Ifc4.Interfaces.IfcSlabTypeEnum.BASESLAB:
						PredefinedType = IfcSlabTypeEnum.BASESLAB;
						return;
					case Ifc4.Interfaces.IfcSlabTypeEnum.USERDEFINED:
						PredefinedType = IfcSlabTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcSlabTypeEnum.NOTDEFINED:
						PredefinedType = IfcSlabTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}