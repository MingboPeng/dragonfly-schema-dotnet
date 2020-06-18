/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.22
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
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;


namespace DragonflySchema
{
    /// <summary>
    /// Base class for for a series of louvered shades over a wall.
    /// </summary>
    [DataContract]
    public partial class LouversBase : HoneybeeObject, IEquatable<LouversBase>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LouversBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LouversBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LouversBase" /> class.
        /// </summary>
        /// <param name="depth">A number for the depth to extrude the louvers. (required).</param>
        /// <param name="offset">A number for the distance to louvers from the wall. (default to 0D).</param>
        /// <param name="angle">A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. (default to 0D).</param>
        /// <param name="contourVector">A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours..</param>
        /// <param name="flipStartSide">Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left. (default to false).</param>
        public LouversBase
        (
             double depth, // Required parameters
            double offset = 0D, double angle = 0D, List<double> contourVector= default, bool flipStartSide = false // Optional parameters
        )// BaseClass
        {
            // to ensure "depth" is required (not null)
            if (depth == null)
            {
                throw new InvalidDataException("depth is a required property for LouversBase and cannot be null");
            }
            else
            {
                this.Depth = depth;
            }
            
            // use default value if no "offset" provided
            if (offset == null)
            {
                this.Offset = 0D;
            }
            else
            {
                this.Offset = offset;
            }
            // use default value if no "angle" provided
            if (angle == null)
            {
                this.Angle = 0D;
            }
            else
            {
                this.Angle = angle;
            }
            this.ContourVector = contourVector;
            // use default value if no "flipStartSide" provided
            if (flipStartSide == null)
            {
                this.FlipStartSide = false;
            }
            else
            {
                this.FlipStartSide = flipStartSide;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "_LouversBase";
        }
        
        /// <summary>
        /// A number for the depth to extrude the louvers.
        /// </summary>
        /// <value>A number for the depth to extrude the louvers.</value>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        [JsonProperty("depth")]
        public double Depth { get; set; } 
        /// <summary>
        /// A number for the distance to louvers from the wall.
        /// </summary>
        /// <value>A number for the distance to louvers from the wall.</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        [JsonProperty("offset")]
        public double Offset { get; set; }  = 0D;
        /// <summary>
        /// A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.
        /// </summary>
        /// <value>A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.</value>
        [DataMember(Name="angle", EmitDefaultValue=false)]
        [JsonProperty("angle")]
        public double Angle { get; set; }  = 0D;
        /// <summary>
        /// A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours.
        /// </summary>
        /// <value>A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours.</value>
        [DataMember(Name="contour_vector", EmitDefaultValue=false)]
        [JsonProperty("contour_vector")]
        public List<double> ContourVector { get; set; } 
        /// <summary>
        /// Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left.
        /// </summary>
        /// <value>Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left.</value>
        [DataMember(Name="flip_start_side", EmitDefaultValue=false)]
        [JsonProperty("flip_start_side")]
        public bool FlipStartSide { get; set; }  = false;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"LouversBase {iDd.Identifier}";
       
            return "LouversBase";
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
            sb.Append("LouversBase:\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  ContourVector: ").Append(ContourVector).Append("\n");
            sb.Append("  FlipStartSide: ").Append(FlipStartSide).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>LouversBase object</returns>
        public static LouversBase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<LouversBase>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LouversBase);
        }

        /// <summary>
        /// Returns true if LouversBase instances are equal
        /// </summary>
        /// <param name="input">Instance of LouversBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LouversBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Angle == input.Angle ||
                    (this.Angle != null &&
                    this.Angle.Equals(input.Angle))
                ) && 
                (
                    this.ContourVector == input.ContourVector ||
                    this.ContourVector != null &&
                    input.ContourVector != null &&
                    this.ContourVector.SequenceEqual(input.ContourVector)
                ) && 
                (
                    this.FlipStartSide == input.FlipStartSide ||
                    (this.FlipStartSide != null &&
                    this.FlipStartSide.Equals(input.FlipStartSide))
                ) && 
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
                int hashCode = 41;
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Angle != null)
                    hashCode = hashCode * 59 + this.Angle.GetHashCode();
                if (this.ContourVector != null)
                    hashCode = hashCode * 59 + this.ContourVector.GetHashCode();
                if (this.FlipStartSide != null)
                    hashCode = hashCode * 59 + this.FlipStartSide.GetHashCode();
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
            // Offset (double) minimum
            if(this.Offset < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Offset, must be a value greater than or equal to 0.", new [] { "Offset" });
            }

            // Angle (double) maximum
            if(this.Angle > (double)90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Angle, must be a value less than or equal to 90.", new [] { "Angle" });
            }

            // Angle (double) minimum
            if(this.Angle < (double)-90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Angle, must be a value greater than or equal to -90.", new [] { "Angle" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^_LouversBase$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
