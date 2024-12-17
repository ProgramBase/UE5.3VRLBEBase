using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DummySpacerCameraTypes")]
	public partial class FDummySpacerCameraTypes : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DummySpacerCameraTypes");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDummySpacerCameraTypes() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDummySpacerCameraTypes() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDummySpacerCameraTypes A, FDummySpacerCameraTypes B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDummySpacerCameraTypes A, FDummySpacerCameraTypes B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDummySpacerCameraTypes;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}