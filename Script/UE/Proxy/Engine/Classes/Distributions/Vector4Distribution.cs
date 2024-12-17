using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Vector4Distribution")]
	public partial class FVector4Distribution : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.Vector4Distribution");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVector4Distribution() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVector4Distribution() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVector4Distribution A, FVector4Distribution B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVector4Distribution A, FVector4Distribution B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVector4Distribution;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDistributionLookupTable Table
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Table, __ReturnBuffer);

					return *(FDistributionLookupTable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Table, __InBuffer);
				}
			}
		}

		private static uint __Table = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}