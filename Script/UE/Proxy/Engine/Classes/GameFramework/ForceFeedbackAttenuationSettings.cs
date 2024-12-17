using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ForceFeedbackAttenuationSettings")]
	public partial class FForceFeedbackAttenuationSettings : FBaseAttenuationSettings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ForceFeedbackAttenuationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FForceFeedbackAttenuationSettings()
		{
		}

		public static bool operator ==(FForceFeedbackAttenuationSettings A, FForceFeedbackAttenuationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FForceFeedbackAttenuationSettings A, FForceFeedbackAttenuationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FForceFeedbackAttenuationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}