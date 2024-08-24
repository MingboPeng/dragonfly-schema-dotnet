﻿import { IsString, IsOptional, IsNumber, IsEnum, ValidateNested, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { _GridParameterBase } from "./_GridParameterBase";
import { ExteriorFaceType } from "./ExteriorFaceType";

/** Instructions for a SensorGrid generated from exterior Faces. */
export class ExteriorFaceGridParameter extends _GridParameterBase {
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsNumber()
    @IsOptional()
    /** A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters). */
    offset?: number;
	
    @IsEnum(ExteriorFaceType)
    @ValidateNested()
    @IsOptional()
    /** Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever. */
    face_type?: ExteriorFaceType;
	
    @IsBoolean()
    @IsOptional()
    /** A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False). */
    punched_geometry?: boolean;
	

    constructor() {
        super();
        this.type = "ExteriorFaceGridParameter";
        this.offset = 0.1;
        this.face_type = ExteriorFaceType.Wall;
        this.punched_geometry = false;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.type = _data["type"] !== undefined ? _data["type"] : "ExteriorFaceGridParameter";
            this.offset = _data["offset"] !== undefined ? _data["offset"] : 0.1;
            this.face_type = _data["face_type"] !== undefined ? _data["face_type"] : ExteriorFaceType.Wall;
            this.punched_geometry = _data["punched_geometry"] !== undefined ? _data["punched_geometry"] : false;
        }
    }


    static override fromJS(data: any): ExteriorFaceGridParameter {
        data = typeof data === 'object' ? data : {};

        let result = new ExteriorFaceGridParameter();
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
        data["offset"] = this.offset;
        data["face_type"] = this.face_type;
        data["punched_geometry"] = this.punched_geometry;
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