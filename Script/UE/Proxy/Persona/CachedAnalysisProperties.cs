using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.CachedAnalysisProperties")]
	public partial class UCachedAnalysisProperties : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.CachedAnalysisProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}