﻿using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.WeldMeshEdgesToolBuilder")]
	public partial class UWeldMeshEdgesToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.WeldMeshEdgesToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}