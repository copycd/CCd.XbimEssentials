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
namespace Xbim.Ifc4x3.Kernel
{
	public partial class @IfcRelAssigns : IIfcRelAssigns
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssigns), 5)]
		IItemSet<IIfcObjectDefinition> IIfcRelAssigns.RelatedObjects 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcObjectDefinition, IIfcObjectDefinition>(RelatedObjects);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcRelAssigns), 6)]
		Ifc4.Interfaces.IfcObjectTypeEnum? IIfcRelAssigns.RelatedObjectsType 
		{ 
			get
			{
				//## Handle return of RelatedObjectsType for which no match was found
				return Ifc4.Interfaces.IfcObjectTypeEnum.NOTDEFINED;	// Not supported in IFC4x3
                //##
            } 
			set
			{
				//## Handle setting of RelatedObjectsType for which no match was found
				// Do nothing. Deprecated in IFC4
				//##
				
			}
		}
	//## Custom code
	//##
	}
}