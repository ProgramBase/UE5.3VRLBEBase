﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionDecalLifetimeOpacity")]
	public partial class UMaterialExpressionDecalLifetimeOpacity : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionDecalLifetimeOpacity");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}