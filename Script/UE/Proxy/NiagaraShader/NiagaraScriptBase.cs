using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.NiagaraScriptBase")]
	public partial class UNiagaraScriptBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraShader.NiagaraScriptBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}