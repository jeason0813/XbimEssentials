// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ConstraintResource
{
	[ExpressType("IFCRESOURCECONSTRAINTRELATIONSHIP", 956)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcResourceConstraintRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IEqualityComparer<@IfcResourceConstraintRelationship>, IEquatable<@IfcResourceConstraintRelationship>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResourceConstraintRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcConstraint _relatingConstraint;
		private ItemSet<IfcResourceObjectSelect> _relatedResourceObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcConstraint @RelatingConstraint 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingConstraint;
				((IPersistEntity)this).Activate(false);
				return _relatingConstraint;
			} 
			set
			{
				SetValue( v =>  _relatingConstraint = v, _relatingConstraint, value,  "RelatingConstraint");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcResourceObjectSelect> @RelatedResourceObjects 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedResourceObjects;
				((IPersistEntity)this).Activate(false);
				return _relatedResourceObjects;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_relatingConstraint = (IfcConstraint)(value.EntityVal);
					return;
				case 3: 
					if (_relatedResourceObjects == null) _relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this );
					_relatedResourceObjects.InternalAdd((IfcResourceObjectSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcResourceConstraintRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcResourceConstraintRelationship
            var root = (@IfcResourceConstraintRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcResourceConstraintRelationship left, @IfcResourceConstraintRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcResourceConstraintRelationship left, @IfcResourceConstraintRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcResourceConstraintRelationship x, @IfcResourceConstraintRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcResourceConstraintRelationship obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}