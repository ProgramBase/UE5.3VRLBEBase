using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraScriptSourceBase")]
	public partial class UNiagaraScriptSourceBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraScriptSourceBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}