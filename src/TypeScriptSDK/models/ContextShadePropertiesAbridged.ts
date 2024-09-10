﻿import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { ContextShadeEnergyPropertiesAbridged } from "./ContextShadeEnergyPropertiesAbridged";
import { ContextShadeRadiancePropertiesAbridged } from "./ContextShadeRadiancePropertiesAbridged";

export class ContextShadePropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^ContextShadePropertiesAbridged$/)
    type?: string;
	
    @IsInstance(ContextShadeEnergyPropertiesAbridged)
    @Type(() => ContextShadeEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    energy?: ContextShadeEnergyPropertiesAbridged;
	
    @IsInstance(ContextShadeRadiancePropertiesAbridged)
    @Type(() => ContextShadeRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    radiance?: ContextShadeRadiancePropertiesAbridged;
	

    constructor() {
        super();
        this.type = "ContextShadePropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ContextShadePropertiesAbridged, _data);
            this.type = obj.type;
            this.energy = obj.energy;
            this.radiance = obj.radiance;
        }
    }


    static override fromJS(data: any): ContextShadePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new ContextShadePropertiesAbridged();
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
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
