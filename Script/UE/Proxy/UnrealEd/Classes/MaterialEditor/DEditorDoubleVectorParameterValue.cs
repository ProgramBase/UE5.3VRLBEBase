﻿using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DEditorDoubleVectorParameterValue")]
	public partial class UDEditorDoubleVectorParameterValue : UDEditorParameterValue, IStaticClass
	{
		public FVector4d ParameterValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __ReturnBuffer);

					return *(FVector4d*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DEditorDoubleVectorParameterValue");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ParameterValue = 0;
	}
}