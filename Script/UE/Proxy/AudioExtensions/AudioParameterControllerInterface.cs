using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.AudioParameterControllerInterface")]
	public partial class UAudioParameterControllerInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.AudioParameterControllerInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AudioExtensions.AudioParameterControllerInterface")]
	public interface IAudioParameterControllerInterface : IInterface
	{
		 void SetTriggerParameter(FName InName);

		 void SetStringParameter(FName InName, FString InValue);

		 void SetStringArrayParameter(FName InName, TArray<FString> InValue);

		 void SetParameters_Blueprint(TArray<FAudioParameter> InParameters);

		 void SetObjectParameter(FName InName, UObject InValue);

		 void SetObjectArrayParameter(FName InName, TArray<UObject> InValue);

		 void SetIntParameter(FName InName, int InInt);

		 void SetIntArrayParameter(FName InName, TArray<int> InValue);

		 void SetFloatParameter(FName InName, float InFloat);

		 void SetFloatArrayParameter(FName InName, TArray<float> InValue);

		 void SetBoolParameter(FName InName, bool InBool);

		 void SetBoolArrayParameter(FName InName, TArray<bool> InValue);

		 void ResetParameters();
	}
}