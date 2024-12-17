using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PointerToUberGraphFrame")]
	public partial class FPointerToUberGraphFrame : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PointerToUberGraphFrame");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPointerToUberGraphFrame() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPointerToUberGraphFrame() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPointerToUberGraphFrame A, FPointerToUberGraphFrame B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPointerToUberGraphFrame A, FPointerToUberGraphFrame B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPointerToUberGraphFrame;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}