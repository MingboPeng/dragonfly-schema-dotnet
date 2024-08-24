﻿import { IsNumber, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { ElectricEquipmentAbridged } from "./ElectricEquipmentAbridged";
import { GasEquipmentAbridged } from "./GasEquipmentAbridged";
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";

/** Base class for all objects requiring an EnergyPlus identifier and user_data. */
export class _EquipmentBase extends IDdEnergyBaseModel {
    @IsNumber()
    @IsDefined()
    /** Equipment level per floor area as [W/m2]. */
    watts_per_area!: number;
	
    @IsString()
    @IsDefined()
    /** Identifier of the schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile. */
    schedule!: string;
	
    @IsNumber()
    @IsOptional()
    /** Number for the amount of long-wave radiation heat given off by equipment. Default value is 0. */
    radiant_fraction?: number;
	
    @IsNumber()
    @IsOptional()
    /** Number for the amount of latent heat given off by equipment. Default value is 0. */
    latent_fraction?: number;
	
    @IsNumber()
    @IsOptional()
    /** Number for the amount of “lost” heat being given off by equipment. The default value is 0. */
    lost_fraction?: number;
	
    @IsString()
    @IsOptional()
    type?: string;
	

    constructor() {
        super();
        this.radiant_fraction = 0;
        this.latent_fraction = 0;
        this.lost_fraction = 0;
        this.type = "_EquipmentBase";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.watts_per_area = _data["watts_per_area"];
            this.schedule = _data["schedule"];
            this.radiant_fraction = _data["radiant_fraction"] !== undefined ? _data["radiant_fraction"] : 0;
            this.latent_fraction = _data["latent_fraction"] !== undefined ? _data["latent_fraction"] : 0;
            this.lost_fraction = _data["lost_fraction"] !== undefined ? _data["lost_fraction"] : 0;
            this.type = _data["type"] !== undefined ? _data["type"] : "_EquipmentBase";
        }
    }


    static override fromJS(data: any): _EquipmentBase {
        data = typeof data === 'object' ? data : {};

        if (data["type"] === "ElectricEquipmentAbridged") {
            let result = new ElectricEquipmentAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "GasEquipmentAbridged") {
            let result = new GasEquipmentAbridged();
            result.init(data);
            return result;
        }
        let result = new _EquipmentBase();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["watts_per_area"] = this.watts_per_area;
        data["schedule"] = this.schedule;
        data["radiant_fraction"] = this.radiant_fraction;
        data["latent_fraction"] = this.latent_fraction;
        data["lost_fraction"] = this.lost_fraction;
        data["type"] = this.type;
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