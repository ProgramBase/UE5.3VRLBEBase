﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ActorFactoryNiagara")]
	public partial class UActorFactoryNiagara : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.ActorFactoryNiagara");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}