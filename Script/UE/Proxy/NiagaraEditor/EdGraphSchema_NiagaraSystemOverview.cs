using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.EdGraphSchema_NiagaraSystemOverview")]
	public partial class UEdGraphSchema_NiagaraSystemOverview : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.EdGraphSchema_NiagaraSystemOverview");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}