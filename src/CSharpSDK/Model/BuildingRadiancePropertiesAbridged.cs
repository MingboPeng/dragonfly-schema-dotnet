﻿/* 
 * DragonflySchema
 *
 * Contact: info@ladybug.tools
 */

extern alias LBTNewtonSoft;
//using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonSoft::Newtonsoft.Json;
using LBTNewtonSoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;

namespace DragonflySchema
{
    /// <summary>
    /// Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.
    /// </summary>
    [Summary(@"Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.")]
    [System.Serializable]
    [DataContract(Name = "BuildingRadiancePropertiesAbridged")]
    public partial class BuildingRadiancePropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<BuildingRadiancePropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingRadiancePropertiesAbridged" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected BuildingRadiancePropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "BuildingRadiancePropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingRadiancePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="modifierSet">Name of a ModifierSet to specify all modifiers for the Building. If None, the Model global_modifier_set will be used.</param>
        public BuildingRadiancePropertiesAbridged
        (
            string modifierSet = default
        ) : base()
        {
            this.ModifierSet = modifierSet;

            // Set readonly properties with defaultValue
            this.Type = "BuildingRadiancePropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(BuildingRadiancePropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Name of a ModifierSet to specify all modifiers for the Building. If None, the Model global_modifier_set will be used.
        /// </summary>
        [Summary(@"Name of a ModifierSet to specify all modifiers for the Building. If None, the Model global_modifier_set will be used.")]
        [DataMember(Name = "modifier_set")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("modifier_set")] // For System.Text.Json
        public string ModifierSet { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "BuildingRadiancePropertiesAbridged";
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
            sb.Append("BuildingRadiancePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ModifierSet: ").Append(this.ModifierSet).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>BuildingRadiancePropertiesAbridged object</returns>
        public static BuildingRadiancePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BuildingRadiancePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BuildingRadiancePropertiesAbridged object</returns>
        public virtual BuildingRadiancePropertiesAbridged DuplicateBuildingRadiancePropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateBuildingRadiancePropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as BuildingRadiancePropertiesAbridged);
        }


        /// <summary>
        /// Returns true if BuildingRadiancePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildingRadiancePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildingRadiancePropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.ModifierSet, input.ModifierSet);
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
                if (this.ModifierSet != null)
                    hashCode = hashCode * 59 + this.ModifierSet.GetHashCode();
                return hashCode;
            }
        }


    }
}
