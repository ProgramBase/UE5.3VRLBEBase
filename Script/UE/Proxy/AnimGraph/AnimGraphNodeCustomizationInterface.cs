using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNodeCustomizationInterface")]
	public partial class UAnimGraphNodeCustomizationInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNodeCustomizationInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AnimGraph.AnimGraphNodeCustomizationInterface")]
	public interface IAnimGraphNodeCustomizationInterface : IInterface
	{
		 FLinearColor GetTitleColor();
	}
}