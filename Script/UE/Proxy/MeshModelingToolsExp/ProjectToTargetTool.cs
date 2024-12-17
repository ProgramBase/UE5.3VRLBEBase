﻿using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ProjectToTargetTool")]
	public partial class UProjectToTargetTool : URemeshMeshTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.ProjectToTargetTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}