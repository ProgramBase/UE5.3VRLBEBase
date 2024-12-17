using Script.CoreUObject;
using Script.Library;

namespace Script.GameProjectGeneration
{
	[PathName("/Script/GameProjectGeneration.DefaultTemplateProjectDefs")]
	public partial class UDefaultTemplateProjectDefs : UTemplateProjectDefs, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameProjectGeneration.DefaultTemplateProjectDefs");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}