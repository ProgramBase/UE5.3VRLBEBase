﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionStrataUtilityBase")]
	public partial class UMaterialExpressionStrataUtilityBase : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionStrataUtilityBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}