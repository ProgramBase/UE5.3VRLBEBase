﻿using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.AddCylinderPrimitiveTool")]
	public partial class UAddCylinderPrimitiveTool : UAddPrimitiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.AddCylinderPrimitiveTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}