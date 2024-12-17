﻿using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.MaterialXPipelineSettings")]
	public partial class UMaterialXPipelineSettings : UDeveloperSettings, IStaticClass
	{
		public TMap<EInterchangeMaterialXShaders, FSoftObjectPath> PredefinedSurfaceShaders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PredefinedSurfaceShaders, __ReturnBuffer);

					return *(TMap<EInterchangeMaterialXShaders, FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PredefinedSurfaceShaders, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangePipelines.MaterialXPipelineSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PredefinedSurfaceShaders = 0;
	}
}