using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraDumpModuleInfoCommandlet")]
	public partial class UNiagaraDumpModuleInfoCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraDumpModuleInfoCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}