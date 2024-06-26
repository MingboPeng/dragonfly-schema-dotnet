/* 
 * Dragonfly Model Schema
 *
 * Documentation for Dragonfly model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using HoneybeeSchema;
using System.ComponentModel.DataAnnotations;


namespace DragonflySchema
{
    /// <summary>
    /// Gridded skylights defined by an absolute area.
    /// </summary>
    [Serializable]
    [DataContract(Name = "GriddedSkylightArea")]
    public partial class GriddedSkylightArea : OpenAPIGenBaseModel, IEquatable<GriddedSkylightArea>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GriddedSkylightArea" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GriddedSkylightArea() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "GriddedSkylightArea";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GriddedSkylightArea" /> class.
        /// </summary>
        /// <param name="skylightArea">A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio. (required).</param>
        /// <param name="spacing">A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed..</param>
        public GriddedSkylightArea
        (
           double skylightArea, // Required parameters
           AnyOf<Autocalculate, double> spacing= default// Optional parameters
        ) : base()// BaseClass
        {
            this.SkylightArea = skylightArea;
            this.Spacing = spacing;

            // Set non-required readonly properties with defaultValue
            this.Type = "GriddedSkylightArea";

            // check if object is valid
            if (this.GetType() == typeof(GriddedSkylightArea))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "GriddedSkylightArea";

        /// <summary>
        /// A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio.
        /// </summary>
        /// <value>A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio.</value>
        [DataMember(Name = "skylight_area", IsRequired = true)]
        public double SkylightArea { get; set; } 
        /// <summary>
        /// A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed.
        /// </summary>
        /// <value>A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed.</value>
        [DataMember(Name = "spacing")]
        public AnyOf<Autocalculate, double> Spacing { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "GriddedSkylightArea";
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
            sb.Append("GriddedSkylightArea:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SkylightArea: ").Append(SkylightArea).Append("\n");
            sb.Append("  Spacing: ").Append(Spacing).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>GriddedSkylightArea object</returns>
        public static GriddedSkylightArea FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<GriddedSkylightArea>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GriddedSkylightArea object</returns>
        public virtual GriddedSkylightArea DuplicateGriddedSkylightArea()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateGriddedSkylightArea();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateGriddedSkylightArea();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as GriddedSkylightArea);
        }

        /// <summary>
        /// Returns true if GriddedSkylightArea instances are equal
        /// </summary>
        /// <param name="input">Instance of GriddedSkylightArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GriddedSkylightArea input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.SkylightArea == input.SkylightArea ||
                    (this.SkylightArea != null &&
                    this.SkylightArea.Equals(input.SkylightArea))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Spacing == input.Spacing ||
                    (this.Spacing != null &&
                    this.Spacing.Equals(input.Spacing))
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
                if (this.SkylightArea != null)
                    hashCode = hashCode * 59 + this.SkylightArea.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Spacing != null)
                    hashCode = hashCode * 59 + this.Spacing.GetHashCode();
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
            Regex regexType = new Regex(@"^GriddedSkylightArea$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
