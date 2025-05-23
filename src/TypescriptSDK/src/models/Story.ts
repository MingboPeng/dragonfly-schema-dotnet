﻿import { IsArray, IsInstance, ValidateNested, IsDefined, IsString, IsOptional, Matches, IsInt, Min, IsEnum, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { Autocalculate } from "honeybee-schema";
import { IDdBaseModel } from "honeybee-schema";
import { RoofSpecification } from "./RoofSpecification";
import { Room2D } from "./Room2D";
import { StoryPropertiesAbridged } from "./StoryPropertiesAbridged";
import { StoryType } from "./StoryType";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Story extends IDdBaseModel {
    @IsArray()
    @IsInstance(Room2D, { each: true })
    @Type(() => Room2D)
    @ValidateNested({ each: true })
    @IsDefined()
    /** An array of dragonfly Room2D objects that together form an entire story of a building. */
    room_2ds!: Room2D[];
	
    @IsInstance(StoryPropertiesAbridged)
    @Type(() => StoryPropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: StoryPropertiesAbridged;
	
    @IsString()
    @IsOptional()
    @Matches(/^Story$/)
    /** Type */
    type?: string;
	
    @IsOptional()
    /** A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If Autocalculate, this value will be the maximum floor_to_ceiling_height of the input room_2ds. */
    floor_to_floor_height?: (Autocalculate | number);
	
    @IsOptional()
    /** A number to indicate the height of the floor plane in the Z axis.If Autocalculate, this will be the minimum floor height of all the room_2ds, which is suitable for cases where there are no floor plenums. */
    floor_height?: (Autocalculate | number);
	
    @IsInt()
    @IsOptional()
    @Min(1)
    /** An integer that denotes the number of times that this Story is repeated over the height of the building. */
    multiplier?: number;
	
    @IsInstance(RoofSpecification)
    @Type(() => RoofSpecification)
    @ValidateNested()
    @IsOptional()
    /** An optional RoofSpecification object containing geometry for generating sloped roofs over the Story. The RoofSpecification will only affect the child Room2Ds that have a True is_top_exposed property and it will only be utilized in translation to Honeybee when the Story multiplier is 1. If None, all Room2D ceilings will be flat. */
    roof?: RoofSpecification;
	
    @IsEnum(StoryType)
    @Type(() => String)
    @IsOptional()
    /** Text to indicate the type of story. Stories that are plenums are translated to Honeybee with excluded floor areas. */
    story_type?: StoryType;
	

    constructor() {
        super();
        this.type = "Story";
        this.floor_to_floor_height = new Autocalculate();
        this.floor_height = new Autocalculate();
        this.multiplier = 1;
        this.story_type = StoryType.Standard;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Story, _data, { enableImplicitConversion: true });
            this.room_2ds = obj.room_2ds;
            this.properties = obj.properties;
            this.type = obj.type;
            this.floor_to_floor_height = obj.floor_to_floor_height;
            this.floor_height = obj.floor_height;
            this.multiplier = obj.multiplier;
            this.roof = obj.roof;
            this.story_type = obj.story_type;
        }
    }


    static override fromJS(data: any): Story {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Story();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["room_2ds"] = this.room_2ds;
        data["properties"] = this.properties;
        data["type"] = this.type;
        data["floor_to_floor_height"] = this.floor_to_floor_height;
        data["floor_height"] = this.floor_height;
        data["multiplier"] = this.multiplier;
        data["roof"] = this.roof;
        data["story_type"] = this.story_type;
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

