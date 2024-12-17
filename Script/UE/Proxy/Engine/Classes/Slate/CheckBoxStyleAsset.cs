﻿using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CheckBoxStyleAsset")]
	public partial class UCheckBoxStyleAsset : UObject, IStaticClass
	{
		public FCheckBoxStyle CheckBoxStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CheckBoxStyle, __ReturnBuffer);

					return *(FCheckBoxStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CheckBoxStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CheckBoxStyleAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CheckBoxStyle = 0;
	}
}