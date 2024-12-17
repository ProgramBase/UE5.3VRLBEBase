﻿using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeSceneVariantSetsFactory")]
	public partial class UInterchangeSceneVariantSetsFactory : UInterchangeFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeSceneVariantSetsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}