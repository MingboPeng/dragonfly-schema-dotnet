﻿import { IsString, IsOptional, IsArray, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { ExteriorApertureGridParameter } from "./ExteriorApertureGridParameter";
import { ExteriorFaceGridParameter } from "./ExteriorFaceGridParameter";
import { RoomGridParameter } from "./RoomGridParameter";
import { RoomRadialGridParameter } from "./RoomRadialGridParameter";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class Room2DRadiancePropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsString()
    @IsOptional()
    /** Identifier of a ModifierSet to specify all modifiers for the Room2D. If None, the Room2D will use the Story or Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects. */
    modifier_set?: string;
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsOptional()
    /** An optional list of GridParameter objects to describe how sensor grids should be generated for the Room2D. */
    grid_parameters?: (RoomGridParameter | RoomRadialGridParameter | ExteriorFaceGridParameter | ExteriorApertureGridParameter) [];
	

    constructor() {
        super();
        this.type = "Room2DRadiancePropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.type = _data["type"] !== undefined ? _data["type"] : "Room2DRadiancePropertiesAbridged";
            this.modifier_set = _data["modifier_set"];
            this.grid_parameters = _data["grid_parameters"];
        }
    }


    static override fromJS(data: any): Room2DRadiancePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new Room2DRadiancePropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["type"] = this.type;
        data["modifier_set"] = this.modifier_set;
        data["grid_parameters"] = this.grid_parameters;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || {}).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}