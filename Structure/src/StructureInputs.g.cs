// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Structure
{
	public class StructureInputs: S3Args
	{
		/// <summary>
		/// Center to center column distance.
		/// </summary>
		[JsonProperty("Column X-Axis Interval")]
		public double ColumnXAxisInterval {get;}

		/// <summary>
		/// Center to center column distance.
		/// </summary>
		[JsonProperty("Column Y-Axis Interval")]
		public double ColumnYAxisInterval {get;}

		/// <summary>
		/// Column diameter.
		/// </summary>
		[JsonProperty("Column Diameter")]
		public double ColumnDiameter {get;}


		
		/// <summary>
		/// Construct a StructureInputs with default inputs.
		/// This should be used only for testing.
		/// </summary>
		public StructureInputs() : base()
		{
			this.ColumnXAxisInterval = 10;
			this.ColumnYAxisInterval = 10;
			this.ColumnDiameter = 1;

		}
		
		/// <summary>
		/// Construct a StructureInputs specifying all inputs.
		/// </summary>
		/// <returns></returns>
		[JsonConstructor]
		public StructureInputs(double columnxaxisinterval, double columnyaxisinterval, double columndiameter, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
		{
			this.ColumnXAxisInterval = columnxaxisinterval;
			this.ColumnYAxisInterval = columnyaxisinterval;
			this.ColumnDiameter = columndiameter;

		}
	}
}