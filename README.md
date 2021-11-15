[![Build](https://github.com/ladybug-tools/dragonfly-core-dotnet/workflows/CD/badge.svg)](https://github.com/ladybug-tools/dragonfly-core-dotnet/actions) [![NuGet Version and Downloads count](https://buildstats.info/nuget/DragonflySchema?dWidth=50)](https://www.nuget.org/packages/DragonflySchema)

# DragonflySchema - the C# library for the Dragonfly Model Schema

Documentation for Dragonfly model schema

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.6.57
- SDK version: 1.6.57
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/ladybug-tools/dragonfly-core](https://github.com/ladybug-tools/dragonfly-core)

## Frameworks supported


- .NET Core >=1.0
- .NET Framework >=4.5

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using DragonflySchema.Api;
using DragonflySchema.Client;
using DragonflySchema.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out DragonflySchema.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DragonflySchema.Api;
using DragonflySchema.Client;
using DragonflySchema.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------


## Documentation for Models

 - [Model.Adiabatic](docs/Adiabatic.md)
 - [Model.AdiabaticAllOf](docs/AdiabaticAllOf.md)
 - [Model.AirBoundaryConstruction](docs/AirBoundaryConstruction.md)
 - [Model.AirBoundaryConstructionAbridged](docs/AirBoundaryConstructionAbridged.md)
 - [Model.AirBoundaryConstructionAbridgedAllOf](docs/AirBoundaryConstructionAbridgedAllOf.md)
 - [Model.AirBoundaryConstructionAllOf](docs/AirBoundaryConstructionAllOf.md)
 - [Model.AllAirBase](docs/AllAirBase.md)
 - [Model.AllAirBaseAllOf](docs/AllAirBaseAllOf.md)
 - [Model.AllAirEconomizerType](docs/AllAirEconomizerType.md)
 - [Model.ApertureConstructionSet](docs/ApertureConstructionSet.md)
 - [Model.ApertureConstructionSetAbridged](docs/ApertureConstructionSetAbridged.md)
 - [Model.ApertureConstructionSetAbridgedAllOf](docs/ApertureConstructionSetAbridgedAllOf.md)
 - [Model.ApertureConstructionSetAllOf](docs/ApertureConstructionSetAllOf.md)
 - [Model.Autocalculate](docs/Autocalculate.md)
 - [Model.AutocalculateAllOf](docs/AutocalculateAllOf.md)
 - [Model.Autosize](docs/Autosize.md)
 - [Model.AutosizeAllOf](docs/AutosizeAllOf.md)
 - [Model.Baseboard](docs/Baseboard.md)
 - [Model.BaseboardAllOf](docs/BaseboardAllOf.md)
 - [Model.BaseboardEquipmentType](docs/BaseboardEquipmentType.md)
 - [Model.Building](docs/Building.md)
 - [Model.BuildingAllOf](docs/BuildingAllOf.md)
 - [Model.BuildingEnergyPropertiesAbridged](docs/BuildingEnergyPropertiesAbridged.md)
 - [Model.BuildingEnergyPropertiesAbridgedAllOf](docs/BuildingEnergyPropertiesAbridgedAllOf.md)
 - [Model.BuildingPropertiesAbridged](docs/BuildingPropertiesAbridged.md)
 - [Model.BuildingPropertiesAbridgedAllOf](docs/BuildingPropertiesAbridgedAllOf.md)
 - [Model.ConstructionSet](docs/ConstructionSet.md)
 - [Model.ConstructionSetAbridged](docs/ConstructionSetAbridged.md)
 - [Model.ConstructionSetAbridgedAllOf](docs/ConstructionSetAbridgedAllOf.md)
 - [Model.ConstructionSetAllOf](docs/ConstructionSetAllOf.md)
 - [Model.ContextShade](docs/ContextShade.md)
 - [Model.ContextShadeAllOf](docs/ContextShadeAllOf.md)
 - [Model.ContextShadeEnergyPropertiesAbridged](docs/ContextShadeEnergyPropertiesAbridged.md)
 - [Model.ContextShadeEnergyPropertiesAbridgedAllOf](docs/ContextShadeEnergyPropertiesAbridgedAllOf.md)
 - [Model.ContextShadePropertiesAbridged](docs/ContextShadePropertiesAbridged.md)
 - [Model.ContextShadePropertiesAbridgedAllOf](docs/ContextShadePropertiesAbridgedAllOf.md)
 - [Model.ControlType](docs/ControlType.md)
 - [Model.DOASBase](docs/DOASBase.md)
 - [Model.DOASBaseAllOf](docs/DOASBaseAllOf.md)
 - [Model.DatedBaseModel](docs/DatedBaseModel.md)
 - [Model.DatedBaseModelAllOf](docs/DatedBaseModelAllOf.md)
 - [Model.DetailedWindows](docs/DetailedWindows.md)
 - [Model.DetailedWindowsAllOf](docs/DetailedWindowsAllOf.md)
 - [Model.DoorConstructionSet](docs/DoorConstructionSet.md)
 - [Model.DoorConstructionSetAbridged](docs/DoorConstructionSetAbridged.md)
 - [Model.DoorConstructionSetAbridgedAllOf](docs/DoorConstructionSetAbridgedAllOf.md)
 - [Model.DoorConstructionSetAllOf](docs/DoorConstructionSetAllOf.md)
 - [Model.EconomizerType](docs/EconomizerType.md)
 - [Model.ElectricEquipment](docs/ElectricEquipment.md)
 - [Model.ElectricEquipmentAbridged](docs/ElectricEquipmentAbridged.md)
 - [Model.ElectricEquipmentAbridgedAllOf](docs/ElectricEquipmentAbridgedAllOf.md)
 - [Model.ElectricEquipmentAllOf](docs/ElectricEquipmentAllOf.md)
 - [Model.EnergyBaseModel](docs/EnergyBaseModel.md)
 - [Model.EnergyBaseModelAllOf](docs/EnergyBaseModelAllOf.md)
 - [Model.EnergyMaterial](docs/EnergyMaterial.md)
 - [Model.EnergyMaterialAllOf](docs/EnergyMaterialAllOf.md)
 - [Model.EnergyMaterialNoMass](docs/EnergyMaterialNoMass.md)
 - [Model.EnergyMaterialNoMassAllOf](docs/EnergyMaterialNoMassAllOf.md)
 - [Model.EnergyWindowMaterialBlind](docs/EnergyWindowMaterialBlind.md)
 - [Model.EnergyWindowMaterialBlindAllOf](docs/EnergyWindowMaterialBlindAllOf.md)
 - [Model.EnergyWindowMaterialGas](docs/EnergyWindowMaterialGas.md)
 - [Model.EnergyWindowMaterialGasAllOf](docs/EnergyWindowMaterialGasAllOf.md)
 - [Model.EnergyWindowMaterialGasCustom](docs/EnergyWindowMaterialGasCustom.md)
 - [Model.EnergyWindowMaterialGasCustomAllOf](docs/EnergyWindowMaterialGasCustomAllOf.md)
 - [Model.EnergyWindowMaterialGasMixture](docs/EnergyWindowMaterialGasMixture.md)
 - [Model.EnergyWindowMaterialGasMixtureAllOf](docs/EnergyWindowMaterialGasMixtureAllOf.md)
 - [Model.EnergyWindowMaterialGlazing](docs/EnergyWindowMaterialGlazing.md)
 - [Model.EnergyWindowMaterialGlazingAllOf](docs/EnergyWindowMaterialGlazingAllOf.md)
 - [Model.EnergyWindowMaterialShade](docs/EnergyWindowMaterialShade.md)
 - [Model.EnergyWindowMaterialShadeAllOf](docs/EnergyWindowMaterialShadeAllOf.md)
 - [Model.EnergyWindowMaterialSimpleGlazSys](docs/EnergyWindowMaterialSimpleGlazSys.md)
 - [Model.EnergyWindowMaterialSimpleGlazSysAllOf](docs/EnergyWindowMaterialSimpleGlazSysAllOf.md)
 - [Model.EquipmentBase](docs/EquipmentBase.md)
 - [Model.EquipmentBaseAllOf](docs/EquipmentBaseAllOf.md)
 - [Model.EvaporativeCooler](docs/EvaporativeCooler.md)
 - [Model.EvaporativeCoolerAllOf](docs/EvaporativeCoolerAllOf.md)
 - [Model.EvaporativeCoolerEquipmentType](docs/EvaporativeCoolerEquipmentType.md)
 - [Model.ExtrudedBorder](docs/ExtrudedBorder.md)
 - [Model.ExtrudedBorderAllOf](docs/ExtrudedBorderAllOf.md)
 - [Model.FCU](docs/FCU.md)
 - [Model.FCUAllOf](docs/FCUAllOf.md)
 - [Model.FCUEquipmentType](docs/FCUEquipmentType.md)
 - [Model.FCUwithDOASAbridged](docs/FCUwithDOASAbridged.md)
 - [Model.FCUwithDOASAbridgedAllOf](docs/FCUwithDOASAbridgedAllOf.md)
 - [Model.FCUwithDOASEquipmentType](docs/FCUwithDOASEquipmentType.md)
 - [Model.Face3D](docs/Face3D.md)
 - [Model.Face3DAllOf](docs/Face3DAllOf.md)
 - [Model.FaceSubSet](docs/FaceSubSet.md)
 - [Model.FaceSubSetAbridged](docs/FaceSubSetAbridged.md)
 - [Model.FaceSubSetAbridgedAllOf](docs/FaceSubSetAbridgedAllOf.md)
 - [Model.FaceSubSetAllOf](docs/FaceSubSetAllOf.md)
 - [Model.FloorConstructionSet](docs/FloorConstructionSet.md)
 - [Model.FloorConstructionSetAbridged](docs/FloorConstructionSetAbridged.md)
 - [Model.FloorConstructionSetAbridgedAllOf](docs/FloorConstructionSetAbridgedAllOf.md)
 - [Model.FloorConstructionSetAllOf](docs/FloorConstructionSetAllOf.md)
 - [Model.ForcedAirFurnace](docs/ForcedAirFurnace.md)
 - [Model.ForcedAirFurnaceAllOf](docs/ForcedAirFurnaceAllOf.md)
 - [Model.FuelTypes](docs/FuelTypes.md)
 - [Model.FurnaceEquipmentType](docs/FurnaceEquipmentType.md)
 - [Model.GasEquipment](docs/GasEquipment.md)
 - [Model.GasEquipmentAbridged](docs/GasEquipmentAbridged.md)
 - [Model.GasEquipmentAbridgedAllOf](docs/GasEquipmentAbridgedAllOf.md)
 - [Model.GasEquipmentAllOf](docs/GasEquipmentAllOf.md)
 - [Model.GasType](docs/GasType.md)
 - [Model.GasUnitHeater](docs/GasUnitHeater.md)
 - [Model.GasUnitHeaterAllOf](docs/GasUnitHeaterAllOf.md)
 - [Model.GasUnitHeaterEquipmentType](docs/GasUnitHeaterEquipmentType.md)
 - [Model.GlobalConstructionSet](docs/GlobalConstructionSet.md)
 - [Model.GlobalConstructionSetAllOf](docs/GlobalConstructionSetAllOf.md)
 - [Model.Ground](docs/Ground.md)
 - [Model.GroundAllOf](docs/GroundAllOf.md)
 - [Model.HeatCoolBase](docs/HeatCoolBase.md)
 - [Model.HeatCoolBaseAllOf](docs/HeatCoolBaseAllOf.md)
 - [Model.IDdBaseModel](docs/IDdBaseModel.md)
 - [Model.IDdBaseModelAllOf](docs/IDdBaseModelAllOf.md)
 - [Model.IDdEnergyBaseModel](docs/IDdEnergyBaseModel.md)
 - [Model.IDdEnergyBaseModelAllOf](docs/IDdEnergyBaseModelAllOf.md)
 - [Model.IdealAirSystemAbridged](docs/IdealAirSystemAbridged.md)
 - [Model.IdealAirSystemAbridgedAllOf](docs/IdealAirSystemAbridgedAllOf.md)
 - [Model.Infiltration](docs/Infiltration.md)
 - [Model.InfiltrationAbridged](docs/InfiltrationAbridged.md)
 - [Model.InfiltrationAbridgedAllOf](docs/InfiltrationAbridgedAllOf.md)
 - [Model.InfiltrationAllOf](docs/InfiltrationAllOf.md)
 - [Model.Lighting](docs/Lighting.md)
 - [Model.LightingAbridged](docs/LightingAbridged.md)
 - [Model.LightingAbridgedAllOf](docs/LightingAbridgedAllOf.md)
 - [Model.LightingAllOf](docs/LightingAllOf.md)
 - [Model.LouversBase](docs/LouversBase.md)
 - [Model.LouversBaseAllOf](docs/LouversBaseAllOf.md)
 - [Model.LouversByCount](docs/LouversByCount.md)
 - [Model.LouversByCountAllOf](docs/LouversByCountAllOf.md)
 - [Model.LouversByDistance](docs/LouversByDistance.md)
 - [Model.LouversByDistanceAllOf](docs/LouversByDistanceAllOf.md)
 - [Model.Model](docs/Model.md)
 - [Model.ModelAllOf](docs/ModelAllOf.md)
 - [Model.ModelEnergyProperties](docs/ModelEnergyProperties.md)
 - [Model.ModelEnergyPropertiesAllOf](docs/ModelEnergyPropertiesAllOf.md)
 - [Model.ModelProperties](docs/ModelProperties.md)
 - [Model.ModelPropertiesAllOf](docs/ModelPropertiesAllOf.md)
 - [Model.NoLimit](docs/NoLimit.md)
 - [Model.NoLimitAllOf](docs/NoLimitAllOf.md)
 - [Model.OpaqueConstruction](docs/OpaqueConstruction.md)
 - [Model.OpaqueConstructionAbridged](docs/OpaqueConstructionAbridged.md)
 - [Model.OpaqueConstructionAbridgedAllOf](docs/OpaqueConstructionAbridgedAllOf.md)
 - [Model.OpaqueConstructionAllOf](docs/OpaqueConstructionAllOf.md)
 - [Model.OpenAPIGenBaseModel](docs/OpenAPIGenBaseModel.md)
 - [Model.Outdoors](docs/Outdoors.md)
 - [Model.OutdoorsAllOf](docs/OutdoorsAllOf.md)
 - [Model.Overhang](docs/Overhang.md)
 - [Model.OverhangAllOf](docs/OverhangAllOf.md)
 - [Model.PSZ](docs/PSZ.md)
 - [Model.PSZAllOf](docs/PSZAllOf.md)
 - [Model.PSZEquipmentType](docs/PSZEquipmentType.md)
 - [Model.PTAC](docs/PTAC.md)
 - [Model.PTACAllOf](docs/PTACAllOf.md)
 - [Model.PTACEquipmentType](docs/PTACEquipmentType.md)
 - [Model.PVAV](docs/PVAV.md)
 - [Model.PVAVAllOf](docs/PVAVAllOf.md)
 - [Model.PVAVEquipmentType](docs/PVAVEquipmentType.md)
 - [Model.People](docs/People.md)
 - [Model.PeopleAbridged](docs/PeopleAbridged.md)
 - [Model.PeopleAbridgedAllOf](docs/PeopleAbridgedAllOf.md)
 - [Model.PeopleAllOf](docs/PeopleAllOf.md)
 - [Model.Plane](docs/Plane.md)
 - [Model.PlaneAllOf](docs/PlaneAllOf.md)
 - [Model.ProcessAbridged](docs/ProcessAbridged.md)
 - [Model.ProcessAbridgedAllOf](docs/ProcessAbridgedAllOf.md)
 - [Model.ProgramType](docs/ProgramType.md)
 - [Model.ProgramTypeAbridged](docs/ProgramTypeAbridged.md)
 - [Model.ProgramTypeAbridgedAllOf](docs/ProgramTypeAbridgedAllOf.md)
 - [Model.ProgramTypeAllOf](docs/ProgramTypeAllOf.md)
 - [Model.RectangularWindows](docs/RectangularWindows.md)
 - [Model.RectangularWindowsAllOf](docs/RectangularWindowsAllOf.md)
 - [Model.RepeatingWindowRatio](docs/RepeatingWindowRatio.md)
 - [Model.RepeatingWindowRatioAllOf](docs/RepeatingWindowRatioAllOf.md)
 - [Model.Residential](docs/Residential.md)
 - [Model.ResidentialAllOf](docs/ResidentialAllOf.md)
 - [Model.ResidentialEquipmentType](docs/ResidentialEquipmentType.md)
 - [Model.RoofCeilingConstructionSet](docs/RoofCeilingConstructionSet.md)
 - [Model.RoofCeilingConstructionSetAbridged](docs/RoofCeilingConstructionSetAbridged.md)
 - [Model.RoofCeilingConstructionSetAbridgedAllOf](docs/RoofCeilingConstructionSetAbridgedAllOf.md)
 - [Model.RoofCeilingConstructionSetAllOf](docs/RoofCeilingConstructionSetAllOf.md)
 - [Model.Room2D](docs/Room2D.md)
 - [Model.Room2DAllOf](docs/Room2DAllOf.md)
 - [Model.Room2DEnergyPropertiesAbridged](docs/Room2DEnergyPropertiesAbridged.md)
 - [Model.Room2DEnergyPropertiesAbridgedAllOf](docs/Room2DEnergyPropertiesAbridgedAllOf.md)
 - [Model.Room2DPropertiesAbridged](docs/Room2DPropertiesAbridged.md)
 - [Model.Room2DPropertiesAbridgedAllOf](docs/Room2DPropertiesAbridgedAllOf.md)
 - [Model.Roughness](docs/Roughness.md)
 - [Model.SHWEquipmentType](docs/SHWEquipmentType.md)
 - [Model.SHWSystem](docs/SHWSystem.md)
 - [Model.SHWSystemAllOf](docs/SHWSystemAllOf.md)
 - [Model.ScheduleDay](docs/ScheduleDay.md)
 - [Model.ScheduleDayAllOf](docs/ScheduleDayAllOf.md)
 - [Model.ScheduleFixedInterval](docs/ScheduleFixedInterval.md)
 - [Model.ScheduleFixedIntervalAbridged](docs/ScheduleFixedIntervalAbridged.md)
 - [Model.ScheduleFixedIntervalAbridgedAllOf](docs/ScheduleFixedIntervalAbridgedAllOf.md)
 - [Model.ScheduleFixedIntervalAllOf](docs/ScheduleFixedIntervalAllOf.md)
 - [Model.ScheduleNumericType](docs/ScheduleNumericType.md)
 - [Model.ScheduleRuleAbridged](docs/ScheduleRuleAbridged.md)
 - [Model.ScheduleRuleAbridgedAllOf](docs/ScheduleRuleAbridgedAllOf.md)
 - [Model.ScheduleRuleset](docs/ScheduleRuleset.md)
 - [Model.ScheduleRulesetAbridged](docs/ScheduleRulesetAbridged.md)
 - [Model.ScheduleRulesetAbridgedAllOf](docs/ScheduleRulesetAbridgedAllOf.md)
 - [Model.ScheduleRulesetAllOf](docs/ScheduleRulesetAllOf.md)
 - [Model.ScheduleTypeLimit](docs/ScheduleTypeLimit.md)
 - [Model.ScheduleTypeLimitAllOf](docs/ScheduleTypeLimitAllOf.md)
 - [Model.ScheduleUnitType](docs/ScheduleUnitType.md)
 - [Model.ServiceHotWater](docs/ServiceHotWater.md)
 - [Model.ServiceHotWaterAbridged](docs/ServiceHotWaterAbridged.md)
 - [Model.ServiceHotWaterAbridgedAllOf](docs/ServiceHotWaterAbridgedAllOf.md)
 - [Model.ServiceHotWaterAllOf](docs/ServiceHotWaterAllOf.md)
 - [Model.Setpoint](docs/Setpoint.md)
 - [Model.SetpointAbridged](docs/SetpointAbridged.md)
 - [Model.SetpointAbridgedAllOf](docs/SetpointAbridgedAllOf.md)
 - [Model.SetpointAllOf](docs/SetpointAllOf.md)
 - [Model.ShadeConstruction](docs/ShadeConstruction.md)
 - [Model.ShadeConstructionAllOf](docs/ShadeConstructionAllOf.md)
 - [Model.ShadeLocation](docs/ShadeLocation.md)
 - [Model.SimpleWindowRatio](docs/SimpleWindowRatio.md)
 - [Model.SimpleWindowRatioAllOf](docs/SimpleWindowRatioAllOf.md)
 - [Model.SingleWindow](docs/SingleWindow.md)
 - [Model.SingleWindowAllOf](docs/SingleWindowAllOf.md)
 - [Model.SlatOrientation](docs/SlatOrientation.md)
 - [Model.Story](docs/Story.md)
 - [Model.StoryAllOf](docs/StoryAllOf.md)
 - [Model.StoryEnergyPropertiesAbridged](docs/StoryEnergyPropertiesAbridged.md)
 - [Model.StoryEnergyPropertiesAbridgedAllOf](docs/StoryEnergyPropertiesAbridgedAllOf.md)
 - [Model.StoryPropertiesAbridged](docs/StoryPropertiesAbridged.md)
 - [Model.StoryPropertiesAbridgedAllOf](docs/StoryPropertiesAbridgedAllOf.md)
 - [Model.Surface](docs/Surface.md)
 - [Model.SurfaceAllOf](docs/SurfaceAllOf.md)
 - [Model.TemplateSystem](docs/TemplateSystem.md)
 - [Model.TemplateSystemAllOf](docs/TemplateSystemAllOf.md)
 - [Model.Units](docs/Units.md)
 - [Model.VAV](docs/VAV.md)
 - [Model.VAVAllOf](docs/VAVAllOf.md)
 - [Model.VAVEquipmentType](docs/VAVEquipmentType.md)
 - [Model.VRF](docs/VRF.md)
 - [Model.VRFAllOf](docs/VRFAllOf.md)
 - [Model.VRFEquipmentType](docs/VRFEquipmentType.md)
 - [Model.VRFwithDOASAbridged](docs/VRFwithDOASAbridged.md)
 - [Model.VRFwithDOASAbridgedAllOf](docs/VRFwithDOASAbridgedAllOf.md)
 - [Model.VRFwithDOASEquipmentType](docs/VRFwithDOASEquipmentType.md)
 - [Model.Ventilation](docs/Ventilation.md)
 - [Model.VentilationAbridged](docs/VentilationAbridged.md)
 - [Model.VentilationAbridgedAllOf](docs/VentilationAbridgedAllOf.md)
 - [Model.VentilationAllOf](docs/VentilationAllOf.md)
 - [Model.VentilationControlAbridged](docs/VentilationControlAbridged.md)
 - [Model.VentilationControlAbridgedAllOf](docs/VentilationControlAbridgedAllOf.md)
 - [Model.VentilationOpening](docs/VentilationOpening.md)
 - [Model.VentilationOpeningAllOf](docs/VentilationOpeningAllOf.md)
 - [Model.Vintages](docs/Vintages.md)
 - [Model.WSHP](docs/WSHP.md)
 - [Model.WSHPAllOf](docs/WSHPAllOf.md)
 - [Model.WSHPEquipmentType](docs/WSHPEquipmentType.md)
 - [Model.WSHPwithDOASAbridged](docs/WSHPwithDOASAbridged.md)
 - [Model.WSHPwithDOASAbridgedAllOf](docs/WSHPwithDOASAbridgedAllOf.md)
 - [Model.WSHPwithDOASEquipmentType](docs/WSHPwithDOASEquipmentType.md)
 - [Model.WallConstructionSet](docs/WallConstructionSet.md)
 - [Model.WallConstructionSetAbridged](docs/WallConstructionSetAbridged.md)
 - [Model.WallConstructionSetAbridgedAllOf](docs/WallConstructionSetAbridgedAllOf.md)
 - [Model.WallConstructionSetAllOf](docs/WallConstructionSetAllOf.md)
 - [Model.WindowAC](docs/WindowAC.md)
 - [Model.WindowACAllOf](docs/WindowACAllOf.md)
 - [Model.WindowACEquipmentType](docs/WindowACEquipmentType.md)
 - [Model.WindowConstruction](docs/WindowConstruction.md)
 - [Model.WindowConstructionAbridged](docs/WindowConstructionAbridged.md)
 - [Model.WindowConstructionAbridgedAllOf](docs/WindowConstructionAbridgedAllOf.md)
 - [Model.WindowConstructionAllOf](docs/WindowConstructionAllOf.md)
 - [Model.WindowConstructionDynamic](docs/WindowConstructionDynamic.md)
 - [Model.WindowConstructionDynamicAllOf](docs/WindowConstructionDynamicAllOf.md)
 - [Model.WindowConstructionShade](docs/WindowConstructionShade.md)
 - [Model.WindowConstructionShadeAbridged](docs/WindowConstructionShadeAbridged.md)
 - [Model.WindowConstructionShadeAbridgedAllOf](docs/WindowConstructionShadeAbridgedAllOf.md)
 - [Model.WindowConstructionShadeAllOf](docs/WindowConstructionShadeAllOf.md)


## Documentation for Authorization

All endpoints do not require authorization.
