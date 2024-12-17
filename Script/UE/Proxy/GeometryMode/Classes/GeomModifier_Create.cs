﻿using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryMode
{
	[PathName("/Script/GeometryMode.GeomModifier_Create")]
	public partial class UGeomModifier_Create : UGeomModifier_Edit, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryMode.GeomModifier_Create");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}