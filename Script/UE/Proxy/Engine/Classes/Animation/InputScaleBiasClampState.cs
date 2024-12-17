using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputScaleBiasClampState")]
	public partial class FInputScaleBiasClampState : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InputScaleBiasClampState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInputScaleBiasClampState() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInputScaleBiasClampState() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInputScaleBiasClampState A, FInputScaleBiasClampState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInputScaleBiasClampState A, FInputScaleBiasClampState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInputScaleBiasClampState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}