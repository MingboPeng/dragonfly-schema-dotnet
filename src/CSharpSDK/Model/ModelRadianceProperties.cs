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
    [DataContract(Name = "ModelRadianceProperties")]
    public partial class ModelRadianceProperties : OpenAPIGenBaseModel, System.IEquatable<ModelRadianceProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRadianceProperties" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected ModelRadianceProperties() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ModelRadianceProperties";
            this.GlobalModifierSet = GlobalModifierSetDefault;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRadianceProperties" /> class.
        /// </summary>
        /// <param name="modifierSets">List of all ModifierSets in the Model.</param>
        /// <param name="modifiers">A list of all unique modifiers in the model. This includes modifiers across all the Model modifier_sets.</param>
        public ModelRadianceProperties
        (
            List<AnyOf<ModifierSet, ModifierSetAbridged>> modifierSets = default, List<AnyOf<Plastic, Glass, BSDF, Glow, Light, Trans, Metal, Void, Mirror>> modifiers = default
        ) : base()
        {
            this.ModifierSets = modifierSets;
            this.Modifiers = modifiers;

            // Set readonly properties with defaultValue
            this.Type = "ModelRadianceProperties";
            this.GlobalModifierSet = GlobalModifierSetDefault;

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ModelRadianceProperties))
                this.IsValid(throwException: true);
        }

	
	
        public static readonly GlobalModifierSet GlobalModifierSetDefault = (@"{
  ""type"": ""GlobalModifierSet"",
  ""modifiers"": [
    {
      ""identifier"": ""generic_floor_0.20"",
      ""display_name"": null,
      ""type"": ""Plastic"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_reflectance"": 0.2,
      ""g_reflectance"": 0.2,
      ""b_reflectance"": 0.2,
      ""specularity"": 0.0,
      ""roughness"": 0.0
    },
    {
      ""identifier"": ""generic_wall_0.50"",
      ""display_name"": null,
      ""type"": ""Plastic"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_reflectance"": 0.5,
      ""g_reflectance"": 0.5,
      ""b_reflectance"": 0.5,
      ""specularity"": 0.0,
      ""roughness"": 0.0
    },
    {
      ""identifier"": ""generic_ceiling_0.80"",
      ""display_name"": null,
      ""type"": ""Plastic"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_reflectance"": 0.8,
      ""g_reflectance"": 0.8,
      ""b_reflectance"": 0.8,
      ""specularity"": 0.0,
      ""roughness"": 0.0
    },
    {
      ""identifier"": ""generic_opaque_door_0.50"",
      ""display_name"": null,
      ""type"": ""Plastic"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_reflectance"": 0.5,
      ""g_reflectance"": 0.5,
      ""b_reflectance"": 0.5,
      ""specularity"": 0.0,
      ""roughness"": 0.0
    },
    {
      ""identifier"": ""generic_interior_shade_0.50"",
      ""display_name"": null,
      ""type"": ""Plastic"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_reflectance"": 0.5,
      ""g_reflectance"": 0.5,
      ""b_reflectance"": 0.5,
      ""specularity"": 0.0,
      ""roughness"": 0.0
    },
    {
      ""identifier"": ""generic_exterior_shade_0.35"",
      ""display_name"": null,
      ""type"": ""Plastic"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_reflectance"": 0.35,
      ""g_reflectance"": 0.35,
      ""b_reflectance"": 0.35,
      ""specularity"": 0.0,
      ""roughness"": 0.0
    },
    {
      ""identifier"": ""generic_context_0.20"",
      ""display_name"": null,
      ""type"": ""Plastic"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_reflectance"": 0.2,
      ""g_reflectance"": 0.2,
      ""b_reflectance"": 0.2,
      ""specularity"": 0.0,
      ""roughness"": 0.0
    },
    {
      ""identifier"": ""generic_interior_window_vis_0.88"",
      ""display_name"": null,
      ""type"": ""Glass"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_transmissivity"": 0.9584154328610596,
      ""g_transmissivity"": 0.9584154328610596,
      ""b_transmissivity"": 0.9584154328610596,
      ""refraction_index"": null
    },
    {
      ""identifier"": ""generic_exterior_window_vis_0.64"",
      ""display_name"": null,
      ""type"": ""Glass"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_transmissivity"": 0.6975761815384331,
      ""g_transmissivity"": 0.6975761815384331,
      ""b_transmissivity"": 0.6975761815384331,
      ""refraction_index"": null
    },
    {
      ""identifier"": ""air_boundary"",
      ""display_name"": null,
      ""type"": ""Trans"",
      ""modifier"": null,
      ""dependencies"": [],
      ""r_reflectance"": 1.0,
      ""g_reflectance"": 1.0,
      ""b_reflectance"": 1.0,
      ""specularity"": 0.0,
      ""roughness"": 0.0,
      ""transmitted_diff"": 1.0,
      ""transmitted_spec"": 1.0
    }
  ],
  ""wall_set"": {
    ""exterior_modifier"": ""generic_wall_0.50"",
    ""interior_modifier"": ""generic_wall_0.50"",
    ""type"": ""WallModifierSetAbridged""
  },
  ""floor_set"": {
    ""exterior_modifier"": ""generic_floor_0.20"",
    ""interior_modifier"": ""generic_floor_0.20"",
    ""type"": ""FloorModifierSetAbridged""
  },
  ""roof_ceiling_set"": {
    ""exterior_modifier"": ""generic_ceiling_0.80"",
    ""interior_modifier"": ""generic_ceiling_0.80"",
    ""type"": ""RoofCeilingModifierSetAbridged""
  },
  ""aperture_set"": {
    ""type"": ""ApertureModifierSetAbridged"",
    ""window_modifier"": ""generic_exterior_window_vis_0.64"",
    ""interior_modifier"": ""generic_interior_window_vis_0.88"",
    ""skylight_modifier"": ""generic_exterior_window_vis_0.64"",
    ""operable_modifier"": ""generic_exterior_window_vis_0.64""
  },
  ""door_set"": {
    ""exterior_modifier"": ""generic_opaque_door_0.50"",
    ""interior_modifier"": ""generic_opaque_door_0.50"",
    ""type"": ""DoorModifierSetAbridged"",
    ""interior_glass_modifier"": ""generic_interior_window_vis_0.88"",
    ""exterior_glass_modifier"": ""generic_exterior_window_vis_0.64"",
    ""overhead_modifier"": ""generic_opaque_door_0.50""
  },
  ""shade_set"": {
    ""exterior_modifier"": ""generic_exterior_shade_0.35"",
    ""interior_modifier"": ""generic_interior_shade_0.50"",
    ""type"": ""ShadeModifierSetAbridged""
  },
  ""air_boundary_modifier"": ""air_boundary"",
  ""context_modifier"": ""generic_context_0.20""
}").To<GlobalModifierSet>();
        /// <summary>
        /// Global Radiance modifier set.
        /// </summary>
        [Summary(@"Global Radiance modifier set.")]
        [DataMember(Name = "global_modifier_set")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("global_modifier_set")] // For System.Text.Json
        public GlobalModifierSet GlobalModifierSet { get; protected set; } = GlobalModifierSetDefault;

        /// <summary>
        /// List of all ModifierSets in the Model.
        /// </summary>
        [Summary(@"List of all ModifierSets in the Model.")]
        [DataMember(Name = "modifier_sets")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("modifier_sets")] // For System.Text.Json
        public List<AnyOf<ModifierSet, ModifierSetAbridged>> ModifierSets { get; set; }

        /// <summary>
        /// A list of all unique modifiers in the model. This includes modifiers across all the Model modifier_sets.
        /// </summary>
        [Summary(@"A list of all unique modifiers in the model. This includes modifiers across all the Model modifier_sets.")]
        [DataMember(Name = "modifiers")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("modifiers")] // For System.Text.Json
        public List<AnyOf<Plastic, Glass, BSDF, Glow, Light, Trans, Metal, Void, Mirror>> Modifiers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ModelRadianceProperties";
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
            sb.Append("ModelRadianceProperties:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  GlobalModifierSet: ").Append(this.GlobalModifierSet).Append("\n");
            sb.Append("  ModifierSets: ").Append(this.ModifierSets).Append("\n");
            sb.Append("  Modifiers: ").Append(this.Modifiers).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ModelRadianceProperties object</returns>
        public static ModelRadianceProperties FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ModelRadianceProperties>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ModelRadianceProperties object</returns>
        public virtual ModelRadianceProperties DuplicateModelRadianceProperties()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateModelRadianceProperties();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ModelRadianceProperties);
        }


        /// <summary>
        /// Returns true if ModelRadianceProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelRadianceProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelRadianceProperties input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.GlobalModifierSet, input.GlobalModifierSet) && 
                    Extension.AllEquals(this.ModifierSets, input.ModifierSets) && 
                    Extension.AllEquals(this.Modifiers, input.Modifiers);
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
                if (this.GlobalModifierSet != null)
                    hashCode = hashCode * 59 + this.GlobalModifierSet.GetHashCode();
                if (this.ModifierSets != null)
                    hashCode = hashCode * 59 + this.ModifierSets.GetHashCode();
                if (this.Modifiers != null)
                    hashCode = hashCode * 59 + this.Modifiers.GetHashCode();
                return hashCode;
            }
        }


    }
}
