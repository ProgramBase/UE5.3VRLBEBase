﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DumpMaterialShaderTypesCommandlet")]
	public partial class UDumpMaterialShaderTypesCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DumpMaterialShaderTypesCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}