﻿using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeAnimSequenceFactory")]
	public partial class UInterchangeAnimSequenceFactory : UInterchangeFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeAnimSequenceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}