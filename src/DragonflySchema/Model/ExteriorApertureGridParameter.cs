/* 
 * Dragonfly Model Schema
 *
 * Documentation for Dragonfly model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HoneybeeSchema;
using System.ComponentModel.DataAnnotations;


namespace DragonflySchema
{
    /// <summary>
    /// Instructions for a SensorGrid generated from exterior Aperture.
    /// </summary>
    [Serializable]
    [DataContract(Name = "ExteriorApertureGridParameter")]
    public partial class ExteriorApertureGridParameter : GridParameterBase, IEquatable<ExteriorApertureGridParameter>, IValidatableObject
    {
        /// <summary>
        /// Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces.
        /// </summary>
        /// <value>Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces.</value>
        [DataMember(Name="aperture_type")]
        public ExteriorApertureType ApertureType { get; set; } = ExteriorApertureType.All;
        /// <summary>
        /// Initializes a new instance of the <see cref="ExteriorApertureGridParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExteriorApertureGridParameter() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ExteriorApertureGridParameter";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ExteriorApertureGridParameter" /> class.
        /// </summary>
        /// <param name="offset">A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters). (default to 0.1D).</param>
        /// <param name="apertureType">Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces..</param>
        /// <param name="dimension">The dimension of the grid cells as a number. (required).</param>
        /// <param name="includeMesh">A boolean to note whether the resulting SensorGrid should include the mesh. (default to true).</param>
        public ExteriorApertureGridParameter
        (
            double dimension, // Required parameters
            bool includeMesh = true, double offset = 0.1D, ExteriorApertureType apertureType= ExteriorApertureType.All// Optional parameters
        ) : base(dimension: dimension, includeMesh: includeMesh)// BaseClass
        {
            this.Offset = offset;
            this.ApertureType = apertureType;

            // Set non-required readonly properties with defaultValue
            this.Type = "ExteriorApertureGridParameter";

            // check if object is valid
            if (this.GetType() == typeof(ExteriorApertureGridParameter))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "ExteriorApertureGridParameter";

        /// <summary>
        /// A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters).
        /// </summary>
        /// <value>A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters).</value>
        [DataMember(Name = "offset")]
        public double Offset { get; set; }  = 0.1D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ExteriorApertureGridParameter";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("ExteriorApertureGridParameter:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  IncludeMesh: ").Append(IncludeMesh).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  ApertureType: ").Append(ApertureType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ExteriorApertureGridParameter object</returns>
        public static ExteriorApertureGridParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ExteriorApertureGridParameter>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ExteriorApertureGridParameter object</returns>
        public virtual ExteriorApertureGridParameter DuplicateExteriorApertureGridParameter()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateExteriorApertureGridParameter();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GridParameterBase DuplicateGridParameterBase()
        {
            return DuplicateExteriorApertureGridParameter();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ExteriorApertureGridParameter);
        }

        /// <summary>
        /// Returns true if ExteriorApertureGridParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ExteriorApertureGridParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExteriorApertureGridParameter input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && base.Equals(input) && 
                (
                    this.ApertureType == input.ApertureType ||
                    (this.ApertureType != null &&
                    this.ApertureType.Equals(input.ApertureType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.ApertureType != null)
                    hashCode = hashCode * 59 + this.ApertureType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^ExteriorApertureGridParameter$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
