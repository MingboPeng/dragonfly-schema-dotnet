
# DragonflySchema.Model.ContextShade

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. | 
**DisplayName** | **string** | Display name of the object with no character restrictions. | [optional] 
**UserData** | **Object** | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 
**Geometry** | [**List&lt;AnyOfFace3DMesh3D&gt;**](AnyOfFace3DMesh3D.md) | An array of planar Face3Ds and or Mesh3Ds that together represent the context shade. | 
**Properties** | [**ContextShadePropertiesAbridged**](ContextShadePropertiesAbridged.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**Type** | **string** |  | [optional] [readonly] [default to "ContextShade"]
**IsDetached** | **bool** | Boolean to note whether this shade is detached from any of the other geometry in the model. Cases where this should be True include shade representing surrounding buildings or context. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

