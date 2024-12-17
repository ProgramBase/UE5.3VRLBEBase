﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialEditorMeshComponent")]
	public partial class UMaterialEditorMeshComponent : UStaticMeshComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialEditorMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}