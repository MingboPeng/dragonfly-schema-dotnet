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
    /// Base object for all GridParameters.
    /// </summary>
    [Serializable]
    [DataContract(Name = "_GridParameterBase")]
    public partial class GridParameterBase : OpenAPIGenBaseModel, IEquatable<GridParameterBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridParameterBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GridParameterBase() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "_GridParameterBase";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GridParameterBase" /> class.
        /// </summary>
        /// <param name="dimension">The dimension of the grid cells as a number. (required).</param>
        /// <param name="includeMesh">A boolean to note whether the resulting SensorGrid should include the mesh. (default to true).</param>
        public GridParameterBase
        (
           double dimension, // Required parameters
           bool includeMesh = true // Optional parameters
        ) : base()// BaseClass
        {
            this.Dimension = dimension;
            this.IncludeMesh = includeMesh;

            // Set non-required readonly properties with defaultValue
            this.Type = "_GridParameterBase";

            // check if object is valid
            if (this.GetType() == typeof(GridParameterBase))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "_GridParameterBase";

        /// <summary>
        /// The dimension of the grid cells as a number.
        /// </summary>
        /// <value>The dimension of the grid cells as a number.</value>
        [DataMember(Name = "dimension", IsRequired = true)]
        public double Dimension { get; set; } 
        /// <summary>
        /// A boolean to note whether the resulting SensorGrid should include the mesh.
        /// </summary>
        /// <value>A boolean to note whether the resulting SensorGrid should include the mesh.</value>
        [DataMember(Name = "include_mesh")]
        public bool IncludeMesh { get; set; }  = true;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "GridParameterBase";
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
            sb.Append("GridParameterBase:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  IncludeMesh: ").Append(IncludeMesh).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>GridParameterBase object</returns>
        public static GridParameterBase FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<GridParameterBase>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GridParameterBase object</returns>
        public virtual GridParameterBase DuplicateGridParameterBase()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateGridParameterBase();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateGridParameterBase();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as GridParameterBase);
        }

        /// <summary>
        /// Returns true if GridParameterBase instances are equal
        /// </summary>
        /// <param name="input">Instance of GridParameterBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GridParameterBase input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Dimension == input.Dimension ||
                    (this.Dimension != null &&
                    this.Dimension.Equals(input.Dimension))
                ) && base.Equals(input) && 
                (
                    this.IncludeMesh == input.IncludeMesh ||
                    (this.IncludeMesh != null &&
                    this.IncludeMesh.Equals(input.IncludeMesh))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Dimension != null)
                    hashCode = hashCode * 59 + this.Dimension.GetHashCode();
                if (this.IncludeMesh != null)
                    hashCode = hashCode * 59 + this.IncludeMesh.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^_GridParameterBase$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
