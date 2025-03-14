﻿import { IsString, IsOptional, Matches, MinLength, MaxLength, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class BuildingEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^BuildingEnergyPropertiesAbridged$/)
    /** Type */
    type?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used. */
    construction_set?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Identifier of an OpaqueConstruction for the bottoms of ceiling plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple acoustic tile construction. */
    ceiling_plenum_construction?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Identifier of an OpaqueConstruction for the tops of floor plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple wood plank construction. */
    floor_plenum_construction?: string;
	

    constructor() {
        super();
        this.type = "BuildingEnergyPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(BuildingEnergyPropertiesAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.construction_set = obj.construction_set;
            this.ceiling_plenum_construction = obj.ceiling_plenum_construction;
            this.floor_plenum_construction = obj.floor_plenum_construction;
        }
    }


    static override fromJS(data: any): BuildingEnergyPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new BuildingEnergyPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["construction_set"] = this.construction_set;
        data["ceiling_plenum_construction"] = this.ceiling_plenum_construction;
        data["floor_plenum_construction"] = this.floor_plenum_construction;
        data = super.toJSON(data);
        return instanceToPlain(data);
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

