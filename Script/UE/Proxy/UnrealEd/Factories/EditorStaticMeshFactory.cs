﻿using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorStaticMeshFactory")]
	public partial class UEditorStaticMeshFactory : UActorFactoryStaticMesh, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorStaticMeshFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}