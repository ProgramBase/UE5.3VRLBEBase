﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Engine;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeEditorPipelines
{
	[PathName("/Script/InterchangeEditorPipelines.InterchangeBlueprintPipelineBaseFactory")]
	public partial class UInterchangeBlueprintPipelineBaseFactory : UFactory, IStaticClass
	{
		public EBlueprintType BlueprintType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintType, __ReturnBuffer);

					return *(EBlueprintType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintType, __InBuffer);
				}
			}
		}

		public TSubclassOf<UInterchangePipelineBase> ParentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParentClass, __ReturnBuffer);

					return *(TSubclassOf<UInterchangePipelineBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParentClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEditorPipelines.InterchangeBlueprintPipelineBaseFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BlueprintType = 0;

		private static uint __ParentClass = 0;
	}
}