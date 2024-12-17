﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimBoneCompressionCodec")]
	public partial class UAnimBoneCompressionCodec : UObject, IStaticClass
	{
		public FString Description
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Description, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Description, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimBoneCompressionCodec");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Description = 0;
	}
}