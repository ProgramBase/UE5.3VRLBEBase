﻿using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureReimportSettings")]
	public partial class UFractureReimportSettings : UFractureToolSettings, IStaticClass
	{
		public bool bOddMaterialsAreInternal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOddMaterialsAreInternal, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOddMaterialsAreInternal, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureReimportSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bOddMaterialsAreInternal = 0;
	}
}