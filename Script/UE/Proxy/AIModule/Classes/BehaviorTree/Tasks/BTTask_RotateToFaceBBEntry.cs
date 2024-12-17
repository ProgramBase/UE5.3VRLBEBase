﻿using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTTask_RotateToFaceBBEntry")]
	public partial class UBTTask_RotateToFaceBBEntry : UBTTask_BlackboardBase, IStaticClass
	{
		public float Precision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Precision, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Precision, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTTask_RotateToFaceBBEntry");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Precision = 0;
	}
}