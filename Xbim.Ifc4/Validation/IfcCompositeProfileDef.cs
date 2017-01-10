using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.ProfileResource
{
	public partial class IfcCompositeProfileDef : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.ProfileResource.IfcCompositeProfileDef");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcCompositeProfileDef clause) {
			var retVal = false;
			if (clause == Where.IfcCompositeProfileDef.InvariantProfileType) {
				try {
					retVal = SIZEOF(Profiles.Where(temp => temp.ProfileType != Profiles.ToArray()[0].ProfileType)) == 0;
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcCompositeProfileDef.InvariantProfileType' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			if (clause == Where.IfcCompositeProfileDef.NoRecursion) {
				try {
					retVal = SIZEOF(Profiles.Where(temp => TYPEOF(temp).Contains("IFC4.IFCCOMPOSITEPROFILEDEF"))) == 0;
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcCompositeProfileDef.NoRecursion' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcCompositeProfileDef.InvariantProfileType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompositeProfileDef.InvariantProfileType", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcCompositeProfileDef.NoRecursion))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompositeProfileDef.NoRecursion", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcCompositeProfileDef
	{
		public static readonly IfcCompositeProfileDef InvariantProfileType = new IfcCompositeProfileDef();
		public static readonly IfcCompositeProfileDef NoRecursion = new IfcCompositeProfileDef();
		protected IfcCompositeProfileDef() {}
	}
}