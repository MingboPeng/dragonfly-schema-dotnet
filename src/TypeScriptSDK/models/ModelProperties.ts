﻿import { IsString, IsOptional, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { ModelEnergyProperties } from "./ModelEnergyProperties";
import { ModelRadianceProperties } from "./ModelRadianceProperties";

export class ModelProperties extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsInstance(ModelEnergyProperties)
    @Type(() => ModelEnergyProperties)
    @ValidateNested()
    @IsOptional()
    energy?: ModelEnergyProperties;
	
    @IsInstance(ModelRadianceProperties)
    @Type(() => ModelRadianceProperties)
    @ValidateNested()
    @IsOptional()
    radiance?: ModelRadianceProperties;
	

    constructor() {
        super();
        this.type = "ModelProperties";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ModelProperties, _data);
            this.type = obj.type;
            this.energy = obj.energy;
            this.radiance = obj.radiance;
        }
    }


    static override fromJS(data: any): ModelProperties {
        data = typeof data === 'object' ? data : {};

        let result = new ModelProperties();
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
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error.property]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
