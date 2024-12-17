using Script.CoreUObject;
using Script.Library;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.SequenceRecordingBase")]
	public partial class USequenceRecordingBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequenceRecorder.SequenceRecordingBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}