using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraShakeUpdateResult")]
	public partial class FCameraShakeUpdateResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CameraShakeUpdateResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCameraShakeUpdateResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCameraShakeUpdateResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCameraShakeUpdateResult A, FCameraShakeUpdateResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCameraShakeUpdateResult A, FCameraShakeUpdateResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCameraShakeUpdateResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}