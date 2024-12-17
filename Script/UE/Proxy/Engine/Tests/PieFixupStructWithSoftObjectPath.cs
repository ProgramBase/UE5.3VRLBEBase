using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PieFixupStructWithSoftObjectPath")]
	public partial class FPieFixupStructWithSoftObjectPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PieFixupStructWithSoftObjectPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPieFixupStructWithSoftObjectPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPieFixupStructWithSoftObjectPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPieFixupStructWithSoftObjectPath A, FPieFixupStructWithSoftObjectPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPieFixupStructWithSoftObjectPath A, FPieFixupStructWithSoftObjectPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPieFixupStructWithSoftObjectPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftObjectPath Path
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Path, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Path, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<AActor> TypedPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TypedPtr, __ReturnBuffer);

					return *(TSoftObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TypedPtr, __InBuffer);
				}
			}
		}

		private static uint __Path = 0;

		private static uint __TypedPtr = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}