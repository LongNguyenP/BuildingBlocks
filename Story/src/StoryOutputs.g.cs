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

namespace Story
{
	public class StoryOutputs: ResultsBase
	{
		/// <summary>
		/// Story count.
		/// </summary>
		[JsonProperty("Story count")]
		public double StoryCount {get;}

		/// <summary>
		/// Room quantity.
		/// </summary>
		[JsonProperty("Room Quantity")]
		public double RoomQuantity {get;}


		
		/// <summary>
		/// Construct a StoryOutputs with default inputs.
		/// This should be used only for testing.
		/// </summary>
		public StoryOutputs() : base()
		{

		}
		
		/// <summary>
		/// Construct a StoryOutputs specifying all inputs.
		/// </summary>
		/// <returns></returns>
		[JsonConstructor]
		public StoryOutputs(double storycount, double roomquantity): base()
		{
			this.StoryCount = storycount;
			this.RoomQuantity = roomquantity;

		}
	}
}