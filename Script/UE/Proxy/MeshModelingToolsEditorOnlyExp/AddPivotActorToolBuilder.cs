﻿using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.AddPivotActorToolBuilder")]
	public partial class UAddPivotActorToolBuilder : UMultiSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.AddPivotActorToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}