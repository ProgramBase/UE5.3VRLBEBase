﻿using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackSystemPropertiesGroup")]
	public partial class UNiagaraStackSystemPropertiesGroup : UNiagaraStackItemGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackSystemPropertiesGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}