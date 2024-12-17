﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.EnvironmentQueryEditor
{
	[PathName("/Script/EnvironmentQueryEditor.EnvironmentQueryFactory")]
	public partial class UEnvironmentQueryFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnvironmentQueryEditor.EnvironmentQueryFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}