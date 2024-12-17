using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoftWorldReference")]
	public partial class FSoftWorldReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoftWorldReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoftWorldReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSoftWorldReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSoftWorldReference A, FSoftWorldReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoftWorldReference A, FSoftWorldReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoftWorldReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<UWorld> WorldAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldAsset, __ReturnBuffer);

					return *(TSoftObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldAsset, __InBuffer);
				}
			}
		}

		private static uint __WorldAsset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}