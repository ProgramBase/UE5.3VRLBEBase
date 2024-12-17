using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimTickRecord")]
	public partial class FAnimTickRecord : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimTickRecord");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimTickRecord() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimTickRecord() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimTickRecord A, FAnimTickRecord B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimTickRecord A, FAnimTickRecord B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimTickRecord;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UAnimationAsset SourceAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceAsset, __ReturnBuffer);

					return *(UAnimationAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceAsset, __InBuffer);
				}
			}
		}

		private static uint __SourceAsset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}