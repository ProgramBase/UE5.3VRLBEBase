﻿using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeSkeletalMeshFactory")]
	public partial class UInterchangeSkeletalMeshFactory : UInterchangeFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeSkeletalMeshFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}