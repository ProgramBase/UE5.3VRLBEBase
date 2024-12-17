﻿using Script.CoreUObject;
using Script.GeometryCollectionEngine;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureModalTool")]
	public partial class UFractureModalTool : UFractureActionTool, IStaticClass
	{
		public TArray<UGeometryCollectionComponent> VisualizedCollections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VisualizedCollections, __ReturnBuffer);

					return *(TArray<UGeometryCollectionComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VisualizedCollections, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureModalTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VisualizedCollections = 0;
	}
}