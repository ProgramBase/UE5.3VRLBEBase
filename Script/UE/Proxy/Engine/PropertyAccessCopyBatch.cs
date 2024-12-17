using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PropertyAccessCopyBatch")]
	public partial class FPropertyAccessCopyBatch : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PropertyAccessCopyBatch");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyAccessCopyBatch() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyAccessCopyBatch() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyAccessCopyBatch A, FPropertyAccessCopyBatch B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyAccessCopyBatch A, FPropertyAccessCopyBatch B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyAccessCopyBatch;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPropertyAccessCopy> Copies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Copies, __ReturnBuffer);

					return *(TArray<FPropertyAccessCopy>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Copies, __InBuffer);
				}
			}
		}

		private static uint __Copies = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}