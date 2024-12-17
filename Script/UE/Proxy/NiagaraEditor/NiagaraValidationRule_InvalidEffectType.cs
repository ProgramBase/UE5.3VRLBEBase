﻿using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraValidationRule_InvalidEffectType")]
	public partial class UNiagaraValidationRule_InvalidEffectType : UNiagaraValidationRule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraValidationRule_InvalidEffectType");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}