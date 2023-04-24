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
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [Serializable]
    [DataContract(Name = "ContextShadeRadiancePropertiesAbridged")]
    public partial class ContextShadeRadiancePropertiesAbridged : OpenAPIGenBaseModel, IEquatable<ContextShadeRadiancePropertiesAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShadeRadiancePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="modifier">Name of a Modifier to set the reflectance and specularity of the ContextShade. If None, the the default of 0.2 diffuse reflectance will be used..</param>
        public ContextShadeRadiancePropertiesAbridged
        (
           // Required parameters
           string modifier= default// Optional parameters
        ) : base()// BaseClass
        {
            this.Modifier = modifier;

            // Set non-required readonly properties with defaultValue
            this.Type = "ContextShadeRadiancePropertiesAbridged";

            // check if object is valid
            if (this.GetType() == typeof(ContextShadeRadiancePropertiesAbridged))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "ContextShadeRadiancePropertiesAbridged";

        /// <summary>
        /// Name of a Modifier to set the reflectance and specularity of the ContextShade. If None, the the default of 0.2 diffuse reflectance will be used.
        /// </summary>
        /// <value>Name of a Modifier to set the reflectance and specularity of the ContextShade. If None, the the default of 0.2 diffuse reflectance will be used.</value>
        [DataMember(Name = "modifier")]
        public string Modifier { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ContextShadeRadiancePropertiesAbridged";
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
            sb.Append("ContextShadeRadiancePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ContextShadeRadiancePropertiesAbridged object</returns>
        public static ContextShadeRadiancePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ContextShadeRadiancePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ContextShadeRadiancePropertiesAbridged object</returns>
        public virtual ContextShadeRadiancePropertiesAbridged DuplicateContextShadeRadiancePropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateContextShadeRadiancePropertiesAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateContextShadeRadiancePropertiesAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ContextShadeRadiancePropertiesAbridged);
        }

        /// <summary>
        /// Returns true if ContextShadeRadiancePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ContextShadeRadiancePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContextShadeRadiancePropertiesAbridged input)
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
                    this.Modifier == input.Modifier ||
                    (this.Modifier != null &&
                    this.Modifier.Equals(input.Modifier))
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
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
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
            Regex regexType = new Regex(@"^ContextShadeRadiancePropertiesAbridged$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}