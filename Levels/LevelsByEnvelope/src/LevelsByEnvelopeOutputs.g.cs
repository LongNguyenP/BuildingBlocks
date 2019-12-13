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
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace LevelsByEnvelope
{
    public class LevelsByEnvelopeOutputs: ResultsBase
    {
		/// <summary>
		/// Total number of levels.
		/// </summary>
		[JsonProperty("Level Quantity")]
		public double LevelQuantity {get;}

		/// <summary>
		/// Total aggregate area of all levels.
		/// </summary>
		[JsonProperty("Total Level Area")]
		public double TotalLevelArea {get;}

		/// <summary>
		/// Height of the ground level.
		/// </summary>
		[JsonProperty("Entry Level Height")]
		public double EntryLevelHeight {get;}

		/// <summary>
		/// Height of the mechanical level.
		/// </summary>
		[JsonProperty("Mechanical Level Height")]
		public double MechanicalLevelHeight {get;}


        
        /// <summary>
        /// Construct a LevelsByEnvelopeOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public LevelsByEnvelopeOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a LevelsByEnvelopeOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public LevelsByEnvelopeOutputs(double levelquantity, double totallevelarea, double entrylevelheight, double mechanicallevelheight): base()
        {
			this.LevelQuantity = levelquantity;
			this.TotalLevelArea = totallevelarea;
			this.EntryLevelHeight = entrylevelheight;
			this.MechanicalLevelHeight = mechanicallevelheight;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}