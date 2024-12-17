﻿using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeMessages
{
	[PathName("/Script/InterchangeMessages.InterchangeResultMeshWarning_Generic")]
	public partial class UInterchangeResultMeshWarning_Generic : UInterchangeResultMeshWarning, IStaticClass
	{
		public FText Text
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Text, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Text, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeMessages.InterchangeResultMeshWarning_Generic");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Text = 0;
	}
}